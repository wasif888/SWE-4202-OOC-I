using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wasifnewlibrary_management_system
{
    internal class Book
    {
        public string BookName;
        public int BookId;
        public string Author;
        public string publisher;
        public int quantity;

        public int BorrowBook()
        {
            quantity = quantity - 1;
            return quantity;

        }

    }
}
