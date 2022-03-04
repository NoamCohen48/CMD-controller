using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

using System;
using System.IO;

namespace DesktopForm
{
    internal class CommunicationHandler
    {
        private CMD cmd;
        private Socket socket;

        public CommunicationHandler(CMD cmd)
        {
            this.cmd = cmd;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Connect()
        {
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            ipAddress = IPAddress.Loopback;

            IPEndPoint ipe = new IPEndPoint(ipAddress, cmd.port);

            try
            {
                socket.Connect(ipe);
            }
            catch (ArgumentNullException ae)
            {
                Console.WriteLine("ArgumentNullException : {0}", ae.ToString());
                return false;
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
                return false;
            }


            return true;
        }

        public bool Disconnect()
        {
            Send("Server.end");
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            return true;
        }

        public bool Send(string message)
        {
            string length = message.Length.ToString();
            var data = Encoding.ASCII.GetBytes(string.Concat(length, "\n", message));
            socket.Send(data);
            return true;
        }

        public string Receive()
        {
            StringBuilder sb = new StringBuilder();
            byte[] buffer = new byte[1];
            socket.Receive(buffer);

            var end = Encoding.ASCII.GetBytes("\n");
            while (buffer[0] != end[0])
            {
                sb.Append(Encoding.ASCII.GetString(buffer));
                socket.Receive(buffer, 0, 1, 0);
            }

            // converting lenght
            var length = 0;
            Int32.TryParse(sb.ToString(), out length);

            buffer = new byte[length];
            socket.Receive(buffer);

            return Encoding.ASCII.GetString(buffer);
        }
    }
}
