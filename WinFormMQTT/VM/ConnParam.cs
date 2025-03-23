using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormMQTT.VM
{
    public class ConnParam
    {
        public string ClientID { get; set; }
        public string URL { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool SSL { get; set; }
        public int KeepAlivePeriod { get; set; }


    }
}
