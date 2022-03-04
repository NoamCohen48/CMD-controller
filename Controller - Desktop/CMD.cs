using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopForm
{
    public class CMD
    {
        public string name;
        public string ip;
        public int port;

        public CMD(string name, string ip, int port)
        {
            this.name = name;
            this.ip = ip;
            this.port = port;
        }

        public override string ToString()
        {
            return String.Format("{0} ({1}, {2})", name, ip, port);
        }
    }
}
