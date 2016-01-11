using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotControllerPC
{
    public class ConnectionData
    {
        public ConnectionData()
        {
            addr = "192.168.0.23";
            port = 2000;
        }
        public String addr;
        public int port;
    }
}
