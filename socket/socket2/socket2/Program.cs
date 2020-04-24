using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase;
using SuperWebSocket;

namespace socket2
{
    class Program
    {
        private static WebSocketServer wsserver;
        static void Main(string[] args)
        {
            wsserver = new WebSocketServer();
            int port = 8088;
            wsserver.Setup(port);
            wsserver.NewSessionConnected += wsserver_NewSessionConnected;
            wsserver.NewMessageReceived += wsserver_NewMessageReceived;
            wsserver.NewDataReceived += wsserver_NewDataReceived;
            wsserver.SessionClosed += wsserver_SessionClosed;
            wsserver.Start();
            Console.WriteLine("server is running in port" + port + "press enter key....");
            Console.ReadKey();
            wsserver.Stop();
        }

        private static void wsserver_SessionClosed(WebSocketSession session, CloseReason value)
        {
            Console.WriteLine(" wsserver_SessionClosed");
        }

        private static void wsserver_NewDataReceived(WebSocketSession session, byte[] value)
        {
            Console.WriteLine(" wsserver_NewDataReceived");
        }

        private static void wsserver_NewMessageReceived(WebSocketSession session, string value)
        {
            Console.WriteLine(" wsserver_NewMessageReceived: "+value);
            if (value =="hello ash")
            {
                session.Send("hey you");
            }

        }

        private static void wsserver_NewSessionConnected(WebSocketSession session)
        {
            Console.WriteLine(" wsserver_NewSessionConnected");

        }
    }
}
