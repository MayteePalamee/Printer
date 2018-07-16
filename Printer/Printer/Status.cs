using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class Status
    {
        private String online;
        private String unknown;
        private String offline;

        public String Online
        {
            get { return online; }
            set { online = value; }
        }
        public String Unknown
        {
            get { return unknown; }
            set { unknown = value; }
        }
        public String Offline
        {
            get { return offline; }
            set { offline = value; }
        }
    }
}
