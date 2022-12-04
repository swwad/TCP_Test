using System.Net.Sockets;

namespace TCPClient

{
    // State object for reading client data asynchronously
    public class StateObject
    {
        // Client  socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 4096;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        public int id;

        public StateObject()
        {
            id = this.GetHashCode();
        }

        public bool IsSocketConnected()
        {
            bool part1 = workSocket.Poll(1000, SelectMode.SelectRead);
            bool part2 = (workSocket.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }
    }
}
