using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraray_manager_2._0
{
    internal class Study_Book:Book
    {
        public int isbn;
        public string genre;

        public string getInfo()
        {
            string info = Convert.ToString(id) + "\t" + title + "\t" + author + "\t" + isbn + "\t" + Convert.ToString(quantity);
            return info;
        }


    }
}
