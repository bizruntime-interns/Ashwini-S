using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace chatapplication
{
    class Server
    {
        private static readonly log4net.ILog log =
    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int recv;
            byte[] data = new byte[1024];
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //creating a socket

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050); //binding socket to local ip
            newsock.Bind(ipep);

            newsock.Listen(10);  //Place the socket in listen mode.
            log.Info("Waiting for a client...");

            Socket client = newsock.Accept();    //	Accept an incoming connection on the socket
            IPEndPoint clientep = (IPEndPoint)client.RemoteEndPoint;
            log.InfoFormat("Connected with {0} at port {1}", clientep.Address, clientep.Port);
            string welcome = "Welcome to my test server";

            data = Encoding.UTF8.GetBytes(welcome);
            client.Send(data, data.Length, SocketFlags.None);
            string input;

            while (true)
            {
                data = new byte[1024];
                recv = client.Receive(data);
                if (recv == 0)
                    break;
                log.Info("Client: " + Encoding.UTF8.GetString(data, 0, recv));
                input = Console.ReadLine();
                Console.WriteLine("ASH: " + input);
                client.Send(Encoding.UTF8.GetBytes(input));
            }

            log.InfoFormat("Disconnected from {0}", clientep.Address);
            client.Close();
            newsock.Close();
            Console.ReadLine();
        }
    }
}