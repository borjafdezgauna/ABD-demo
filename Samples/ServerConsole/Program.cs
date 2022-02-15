using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Listen on port 1200. Accept connections from any IP address
                TcpListener server = new TcpListener(IPAddress.Parse("0.0.0.0"), 1200);

                server.Start();

                Console.WriteLine("Server running and listening on port 1200");

                Socket socket = server.AcceptSocket();

                Console.WriteLine("Connection accepted from " + socket.RemoteEndPoint);

                byte[] buffer = new byte[100];

                socket.Receive(buffer);

                ASCIIEncoding encoding = new ASCIIEncoding();
                string clientMessage = encoding.GetString(buffer);
                Console.WriteLine("Message received from client: " + clientMessage);

                socket.Send(encoding.GetBytes("Message received"));
                Console.WriteLine("ACK sent to client.");

                Task.Delay(2000).Wait();

                socket.Close();
                server.Stop();

                Console.WriteLine("Server closed. Press any key to finish...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unhandled error: " + e);
            }
        }
    }
}
