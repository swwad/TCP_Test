using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class TCPClient : Form
    {
        // ManualResetEvent instances signal completion.
        private static ManualResetEvent connectDone = new ManualResetEvent(false);
        private static ManualResetEvent sendDone = new ManualResetEvent(false);
        private static ManualResetEvent receiveDone = new ManualResetEvent(false);
        private Thread clientThread = null;

        private void showMessage(string message)
        {
            this.tbMonitor.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                tbMonitor.AppendText((DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ":" + message).Trim(new char[] { '\r', '\n' }) + "\r\n");
            });
        }

        public void StartClient(object hostInfo)
        {
            // Connect to a remote device.
            try
            {
                string host = hostInfo.ToString();
                IPAddress ipAssress = IPAddress.Parse(host.Split(new char[] { ',' })[0]);
                IPEndPoint remoteEP = new IPEndPoint(ipAssress, Convert.ToInt32(host.Split(new char[] { ',' })[1]));

                // Create a TCP/IP socket.
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Connect to the remote endpoint.
                client.BeginConnect(remoteEP, new AsyncCallback(ConnectCallback), client);
                connectDone.WaitOne();

                // Send test data to the remote device.
                Send(client, "This is a test");
                sendDone.WaitOne();

                // Receive the response from the remote device.
                Receive(client);
                receiveDone.WaitOne();

                // Release the socket.
                if (cbmConnection.Text.Equals("Short"))
                {
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;
                // Complete the connection.
                client.EndConnect(ar);
                Console.WriteLine("Socket connected to {0}", client.RemoteEndPoint.ToString());
                // Signal that the connection has been made.
                connectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Receive(Socket client)
        {
            try
            {
                // Create the state object.
                StateObject state = new StateObject();
                state.workSocket = client;
                // Begin receiving the data from the remote device.
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                // Read data from the remote device.
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.
                    showMessage("Received " + Encoding.ASCII.GetString(state.buffer, 0, bytesRead));
                    receiveDone.Set();
                    // Get the rest of the data.
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Send(Socket client, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);
            // Begin sending the data to the remote device.
            showMessage("Say " + data);
            client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;
                // Complete sending the data to the remote device.
                int bytesSent = client.EndSend(ar);
                // Signal that all bytes have been sent.
                sendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public TCPClient()
        {
            InitializeComponent();
        }

        private void TCPClient_Load(object sender, EventArgs e)
        {
            cbmConnection.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            clientThread = new Thread(new ParameterizedThreadStart(StartClient));
            string ip = this.tbIP.Text;
            string port = this.tbPort.Text;
            clientThread.Start(ip + "," + port);
        }

        private void TCPClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (clientThread != null && clientThread.IsAlive)
            {
                clientThread.Abort();
                clientThread = null;
            }
        }
    }
}
