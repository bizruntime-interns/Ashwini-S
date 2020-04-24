using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace chatclient
{
    class Program
    {
        private static readonly log4net.ILog log =
    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;  //unicode transmitting format 8

            byte[] data = new byte[1024];

            string input, stringData;

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);

            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ipep);

            }
            catch (SocketException e)
            {
                log.Info("Unable to connect to server.");

                log.Info(e.ToString());

                return;
            }

            int recv = server.Receive(data);

            stringData = Encoding.UTF8.GetString(data, 0, recv);

            log.Info(stringData);

            while (true)
            {
                input = Console.ReadLine();

                if (input == "exit")

                    break;

                log.Info("friend: " + input);

                server.Send(Encoding.UTF8.GetBytes(input));

                data = new byte[1024];

                recv = server.Receive(data);

                stringData = Encoding.UTF8.GetString(data, 0, recv);

                byte[] utf8string = System.Text.Encoding.UTF8.GetBytes(stringData);

                log.Info("Server: " + stringData);
            }

            log.Info("Disconnecting from server...");

            server.Shutdown(SocketShutdown.Both);

            server.Close();

            log.Info("Disconnected!");

            Console.ReadLine();

        }
    }
}
