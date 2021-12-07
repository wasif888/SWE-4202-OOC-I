using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wasifnewlibrary_management_system
{
    internal class user
    {
        public int id;
        public string name;
        public string address;
        public string bookid;

        public string getInfo()
        {
            string info = id.ToString() + "\t" + name + "\t" + address + "\t";
            return info;
        }
    }
}

