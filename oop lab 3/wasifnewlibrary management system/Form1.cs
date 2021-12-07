using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wasifnewlibrary_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<user> Users= new List<user>();
        List<Book> Books= new List<Book>();
        private void AddUser_Click(object sender, EventArgs e)
        {
            string name =NameBox.Text;
            int id = Convert .ToInt32(IdBox.Text);
            string address =AddressBox.Text;
            user dummy = new user();
            dummy.name = name;
            dummy.id = id;
            dummy.address = address;
            Users.Add(dummy);
            MessageBox.Show("USER HAS BEEN ADDED");

        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            string BookName = BnameBox.Text;
            int BookID =Convert.ToInt32(BidBox.Text);
            string Author =AuthorBox.Text;
            int Quantity = Convert.ToInt32(QuantityBox.Text);
            Book dummy = new Book();
            dummy.BookName = BookName;
            dummy.BookId = BookID;
            dummy.Author = Author;
            dummy.quantity = Quantity;
            Books.Add(dummy);
            MessageBox.Show("BOOK HAS BEEN ADDED");
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            int userID=Convert.ToInt32(BorrowIDBox.Text);
            int bookID=Convert.ToInt32(BorrowBookIdBox.Text);
          
            
            for(int i=0;i<Books.Count;i++)
            {
                if(Books[i].BookId==bookID)
                {
                    if(Books[i].quantity>=1)
                    {
                        Books[i].BorrowBook();
                        MessageBox.Show("Thanks for borrowing ");
                    }
                    else
                    {
                        MessageBox.Show("There is no book");
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int showBookId= Convert.ToInt32(ShowBookIdBox.Text);
            for(int i=0;i< Books.Count;i++)
            {
                if(Books[i].BookId==showBookId)
                {
                 Bookhistory.Items.Clear();
                 Bookhistory.Items.Add(Users[i].getInfo());
                    int num = Convert.ToInt32(Users[i].bookid);
                    for(int j=0;j<Books.Count;j++)
                    {
                        if(num==Books[j].BookId)
                        {
                            string name=Books[j].BookName;
                            Bookhistory.Items.Add(name);

                        }
                    }

                }
            }
        }

        private void ShowBook_Click(object sender, EventArgs e)
        {
            int RBookId= Convert.ToInt32(RBookBox.Text);
            for(int i=0;i< Books.Count; i++)
            {
                if(Books[i].BookId == RBookId)
                {
                    NameOutLabel.Text=Books[i].BookName;
                    AuthorOUTLabel.Text = Books[i].Author;
                    IdOutLabel.Text = Convert.ToString(Books[i].BookId);
                    QuantityOutLabel.Text=Convert.ToString(Books[i].quantity);
                }
            }
        }
    }
}
