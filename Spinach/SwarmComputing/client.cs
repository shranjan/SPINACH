using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace Spinach
{
    // State object for receiving data from remote device.
    public class StateObject
    {
        // Client socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 256;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder sb = new StringBuilder();
    }

    public class AsynchronousClient
    {
        public static ManualResetEvent[] resetEvent;
        Hashtable table = new Hashtable();
        String MultiMsg;
        String selfip;

        String SingleMsg;
        String targetip;
        String targetport;
        // The port number for the remote device.
        //private const int port = 11000;

        // ManualResetEvent instances signal completion.
        private ManualResetEvent connectDone =
            new ManualResetEvent(false);
        private ManualResetEvent sendDone =
            new ManualResetEvent(false);
        private ManualResetEvent receiveDone =
            new ManualResetEvent(false);

        // The response from the remote device.
        //private String response = String.Empty;
        public void SetSingleMsg(String ip, String port, String msg)
        {
            targetip = ip;
            targetport = port;
            SingleMsg = msg;
        }
        public void SetMultiMsg(Hashtable IPtoPeer, String msg, String self)
        {
            table = IPtoPeer;
            MultiMsg = msg;
            selfip = self;
        }
        public void SendSingleClient()
        {
            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                // The name of the 
                // remote device is "host.contoso.com".
                //IPHostEntry ipHostInfo = Dns.GetHostAddresses("128.230.96.177");
                //IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
                //IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPAddress ipAddress = (Dns.GetHostAddresses(targetip))[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress,Int32.Parse(targetport));

                //Socket client = new Socket(AddressFamily.InterNetwork,
                //        SocketType.Stream, ProtocolType.Tcp);

                {
                    // Create a TCP/IP socket.
                    Socket client = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);

                    // Connect to the remote endpoint.
                    client.BeginConnect(remoteEP,
                        new AsyncCallback(ConnectCallback), client);
                    connectDone.WaitOne();

                    // Send test data to the remote device.
                    string m = SingleMsg + "<EOF>";
                    Send(client, m);
                    sendDone.WaitOne();

                    // Receive the response from the remote device.
                    //Receive(client);
                    //receiveDone.WaitOne();

                    // Write the response to the console.
                    //Console.WriteLine("Response received : {0}", response);

                    // Release the socket.
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void SendMultiClient()
        {
            if (table.Count > 1)
            {
                int count = 0;
                resetEvent = new ManualResetEvent[table.Count - 1];
                foreach (string IPPort in table.Keys)
                {
                    if (IPPort != selfip)
                    {
                        resetEvent[count] = new ManualResetEvent(false);
                        Peer mPeer = (Peer)table[IPPort];
                        string ip = mPeer.mIP;
                        int port = Int32.Parse(mPeer.mPort);
                        BroadcastClient temp = new BroadcastClient(ip, port, MultiMsg);
                        ThreadPool.QueueUserWorkItem(new WaitCallback(temp.StartClient), (object)count);
                        count++;
                    }
                }
                foreach (WaitHandle w in resetEvent)
                {
                    w.WaitOne();
                }
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

                Console.WriteLine("Socket connected to {0}",
                    client.RemoteEndPoint.ToString());

                // Signal that the connection has been made.
                connectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please check the IP");
                //////////////////////////////////////!!!!!!!!!!!!!!!///////////////////
                //if (ErrorChanged != null)
                //    ErrorChanged(error);


            }
        }

        //private void Receive(Socket client)
        //{
        //    try
        //    {
        //        // Create the state object.
        //        StateObject state = new StateObject();
        //        state.workSocket = client;

        //        // Begin receiving the data from the remote device.
        //        client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
        //            new AsyncCallback(ReceiveCallback), state);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }
        //}

        //private  void ReceiveCallback(IAsyncResult ar)
        //{
        //    try
        //    {
        //        // Retrieve the state object and the client socket 
        //        // from the asynchronous state object.
        //        StateObject state = (StateObject)ar.AsyncState;
        //        Socket client = state.workSocket;

        //        // Read data from the remote device.
        //        int bytesRead = client.EndReceive(ar);

        //        if (bytesRead > 0)
        //        {
        //            // There might be more data, so store the data received so far.
        //            state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

        //            // Get the rest of the data.
        //            client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
        //                new AsyncCallback(ReceiveCallback), state);
        //        }
        //        else
        //        {
        //            // All the data has arrived; put it in response.
        //            if (state.sb.Length > 1)
        //            {
        //                response = state.sb.ToString();
        //            }
        //            // Signal that all bytes have been received.
        //            receiveDone.Set();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }
        //}

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