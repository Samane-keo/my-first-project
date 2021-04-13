using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    class clsConnection
    {
        public string serverName { get; set; }
        public string dbName { get; set; }
        public clsConnection()
        {
            this.serverName = "192.1.1.20,12526";
            this.dbName = "DBMain";
        }
    }
}
