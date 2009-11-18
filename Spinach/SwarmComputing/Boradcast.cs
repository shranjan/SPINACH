using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace Spinach
{
        //public class StateObject
        //{
        //    // Client socket.
        //    public Socket workSocket = null;
        //    // Size of receive buffer.
        //    public const int BufferSize = 256;
        //    // Receive buffer.
        //    public byte[] buffer = new byte[BufferSize];
        //    // Received data string.
        //    public StringBuilder sb = new StringBuilder();
        //}

        public class BroadcastClient
        {
            string mIP;
            int mPort;
            string mMsg;

            public BroadcastClient(string IP,int port,string msg) 
            {
                mIP = IP;
                mPort = port;
                mMsg = msg;
            }

            // ManualResetEvent instances signal completion.
            private ManualResetEvent connectDone =
                new ManualResetEvent(false);
            private ManualResetEvent sendDone =
                new ManualResetEvent(false);
            private ManualResetEvent receiveDone =
                new ManualResetEvent(false);


            public void StartClient(object cnt)
            {
                int cCount = (int)cnt;
                // Connect to a remote device.
                try
                {
                    // Establish the remote endpoint for the socket.
                    // The name of the 
                    // remote device is "host.contoso.com".
                    //IPHostEntry ipHostInfo = Dns.GetHostAddresses("128.230.96.177");
                    //IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
                    //IPAddress ipAddress = ipHostInfo.AddressList[0];
                    IPAddress ipAddress = (Dns.GetHostAddresses(mIP))[0];
                    IPEndPoint remoteEP = new IPEndPoint(ipAddress, mPort);

                    //Socket client = new Socket(AddressFamily.InterNetwork,
                    //        SocketType.Stream, ProtocolType.Tcp);

                    //for (int i = 0; i < 10; ++i)
                    {
                        // Create a TCP/IP socket.
                        Socket client = new Socket(AddressFamily.InterNetwork,
                            SocketType.Stream, ProtocolType.Tcp);

                        // Connect to the remote endpoint.
                        client.BeginConnect(remoteEP,
                            new AsyncCallback(ConnectCallback), client);
                        connectDone.WaitOne();

                        // Send test data to the remote device.
                        string m = mMsg + "<EOF>";
                        Send(client, m);
                        sendDone.WaitOne();


                        // Release the socket.
                        client.Shutdown(SocketShutdown.Both);
                        client.Close();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                AsynchronousClient.resetEvent[cCount].Set();
            }

            private void ConnectCallback(IAsyncResult ar)
            {
                try
                {
                    // Retrieve the socket from the state object.
                    Socket client = (Socket)ar.AsyncState;

                    // Complete the connection.
                    client.EndConnect(ar);

                    Console.WriteLine("Socket connected to {0}",
                        client.RemoteEndPoint.ToString());

                    // Signal that the connection has been made.
                    connectDone.Set();
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
                client.BeginSend(byteData, 0, byteData.Length, 0,
                    new AsyncCallback(SendCallback), client);
            }

            private void SendCallback(IAsyncResult ar)
            {
                try
                {
                    // Retrieve the socket from the state object.
                    Socket client = (Socket)ar.AsyncState;

                    // Complete sending the data to the remote device.
                    int bytesSent = client.EndSend(ar);
                    Console.WriteLine("Sent {0} bytes to server.", bytesSent);

                    // Signal that all bytes have been sent.
                    sendDone.Set();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }
    
}
