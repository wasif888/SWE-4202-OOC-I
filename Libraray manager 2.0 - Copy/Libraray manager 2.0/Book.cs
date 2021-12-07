using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraray_manager_2._0
{
    internal class Book
    {
        public int id;
        public string title;
        public string author;
        public string publisher;
        public int quantity;

        public int BorrowBook()
        {
            quantity = quantity - 1;
            return quantity;
        }
    }
}
