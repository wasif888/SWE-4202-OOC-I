using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libraray_manager_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Study_Book> Sbook = new List<Study_Book>();
        List<ResearchArticle>Rbook = new List<ResearchArticle>();
        private void AddStudyBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(SidBox.Text);
            string title = StitleBox.Text;
            string author = SauthorBox.Text;
            string publisher = SpulisherBox.Text;
            int quantity = Convert.ToInt32(SquantityBox.Text);
            int  isbn=Convert.ToInt32(isbnBox.Text);
            string genre = genreBox.Text;
            Study_Book dummy = new Study_Book();
            dummy.id = id;
            dummy.title = title;
            dummy.author = author;
            dummy.publisher = publisher;
            dummy.quantity = quantity;
            dummy.isbn = isbn;
            dummy.genre = genre;
            Sbook.Add(dummy);
            MessageBox.Show("Book Has Been Added");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(RidBox.Text);
            string title =RtitleBox.Text;
            string author =RauthorBox.Text;
            string publisher =RpublisherBox.Text;
            int quantity=Convert.ToInt32(RquantityBox.Text);
            string  Doi =DoiBox.Text;
            string  pub=PublicDataBox.Text;
            string journal =JournalBox.Text;
            ResearchArticle dummy = new ResearchArticle();
            dummy.id = id;
            dummy.title=title;
            dummy.author=author;
            dummy.publisher = publisher;
            dummy.quantity=quantity;
            dummy.doi = Doi;
            dummy.publicData = pub;
            dummy.journal = journal;
            Rbook.Add(dummy);
            MessageBox.Show("Book Has Been Added");
        }

        private void BorrowSbook_Click(object sender, EventArgs e)
        {
            int ID=Convert.ToInt32(BorrowBookId.Text);
            for(int i=0;i<Sbook.Count;i++)
            {
                if(Sbook[i].id==ID)
                { 
                    if (Sbook[i].quantity > 1)
                    {
                        Sbook[i].BorrowBook();
                        MessageBox.Show("BOOK HAS BEEN BORROWED");
                    }
                }
            }
        }

        private void BorrowRbook_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(BorrowArticleID.Text);
            for(int i=0;i< Rbook.Count;i++)
            {
                if(id==Rbook[i].id)
                {
                    if(Rbook[i].quantity > 1)
                    {
                        Rbook[i].BorrowBook();
                        MessageBox.Show("BOOK HAS BEEN BORROWED");
                    }
                }
            }
        }

        private void ShowSbook_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ShowBookID.Text);
            for(int i=0;i< Sbook.Count;i++)
            {
                if(ID==Sbook[i].id)
                {
                    StudyBooksList.Items.Add(Sbook[i].getInfo());
                }
            }
        }

        private void ShowRbook_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ArticleBookId.Text);
            for(int i=0;i< Rbook.Count; i++)
            {
                if(ID == Rbook[i].id)
                {
                    ArticeBooklist.Items.Add(Rbook[i].getInfo());
                }
            }
        }
    }
}
