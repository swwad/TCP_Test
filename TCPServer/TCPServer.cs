using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class TCPServer : Form
    {
        private Thread serverThread = null;
        private static ManualResetEvent allDone = new ManualResetEvent(false);
        private Dictionary<int, StateObject> dictClient = new Dictionary<int, StateObject>();
        const int _CLIENT_LIMIT_ = 10;
        const int _DEFAULT_PORT_ = 3405;
        const int _DEFAULT_HB_ = 30;

        public TCPServer()
        {
            InitializeComponent();
        }

        private void showMessage(string message)
        {
            if (serverThread == null || !serverThread.IsAlive) return;
            this.tbMonitor.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                tbMonitor.AppendText((DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ":" + message).Trim(new char[] { '\r', '\n' }) + "\r\n");
            });
        }

        [Obsolete]
        public void StartListening(object port)
        {
            // Establish the local endpoint for the socket.
            IPEndPoint localEndPoint = new IPEndPoint(Dns.Resolve(Dns.GetHostName()).AddressList[0], Convert.ToInt32(port));
            // Create a TCP/IP socket.
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // Bind the socket to the local endpoint and listen for incoming connections.
            try
            {
                showMessage("Server IP = " + localEndPoint.Address);
                listener.Bind(localEndPoint);
                listener.Listen(_CLIENT_LIMIT_);
                while (true)
                {
                    // Set the event to nonsignaled state.
                    allDone.Reset();
                    // Start an asynchronous socket to listen for connections.
                    listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);
                    // Wait until a connection is made before continuing.
                    allDone.WaitOne();
                }
            }
            catch (Exception e)
            {
                showMessage(e.ToString());
            }
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.
            allDone.Set();
            // Get the socket that handles the client request.
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);
            // Create the state object.
            StateObject state = new StateObject();
            dictClient.Add(state.id, state);
            showMessage("New connection, Client hash is " + state.id);
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
        }

        public void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;
            // Retrieve the state object and the handler socket from the asynchronous state object.
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;
            // Read data from the client socket. 
            int bytesRead = handler.EndReceive(ar);
            if (bytesRead > 0)
            {
                // Data has been read from the client. Display it on the console.
                showMessage("Client " + state.id + " say " + Encoding.ASCII.GetString(state.buffer, 0, bytesRead));
                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
            }
        }

        private void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
            }
            catch (Exception e)
            {
                showMessage(e.ToString());
            }
        }

        [Obsolete]
        private void btnListen_Click(object sender, EventArgs e)
        {
            timerHeartBeat.Interval = (Int32.TryParse(this.tbHeartBeatRate.Text, out int sec) ? sec : _DEFAULT_HB_) * 1000;
            dictClient.Clear();
            serverThread = new Thread(new ParameterizedThreadStart(StartListening));
            serverThread.Start(Int32.TryParse(this.tbPort.Text, out int port) ? port : _DEFAULT_PORT_);
            this.btnListen.Enabled = false;
            if (cbHeartBeat.Checked)
            {
                timerHeartBeat.Start();
            }
        }

        private void TCPServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serverThread != null && serverThread.IsAlive)
            {
                serverThread.Abort();
                serverThread = null;
            }
        }

        private void timerHeartBeat_Tick(object sender, EventArgs e)
        {
            //移除斷掉的連線
            var dictRemoveList = dictClient.Where(d => !d.Value.IsSocketConnected()).Select(k => k.Key).ToList();
            foreach (var id in dictRemoveList)
            {
                dictClient.Remove(id);
            }

            //針對連線中的 Client 發送心跳
            foreach (var stateObject in dictClient)
            {
                Send(stateObject.Value.workSocket, "Client " + stateObject.Key + " is alive.");
            }
        }
    }
}
