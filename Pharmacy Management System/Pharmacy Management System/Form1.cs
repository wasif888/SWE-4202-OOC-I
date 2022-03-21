using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Management_Dependencies;
using System.IO;
namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddMedicine_Click(object sender, EventArgs e)
        {
            string name=MedNameBox.Text;
            string id=MedIdBox.Text; 
            int quantity=Convert.ToInt32(QuantityBox.Text);
            double price=Convert.ToDouble(MedPriceBox.Text);

            Medicine dummy = new Medicine(name, id, quantity, price);
            PMS.medicines.Add(dummy);
            MessageBox.Show("Medicine has been Added");
        }

        private void ClearMedicine_Click(object sender, EventArgs e)
        {
            MedNameBox.Text="";
            MedIdBox.Text="";
            QuantityBox.Text="";
            MedPriceBox.Text="";
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            string userid = Convert.ToString(User.UserIdGenerate)+"400";
            User.UserIdGenerate++;
            double balance=Convert.ToDouble(BalanceBox.Text);

            User dummy=new User(userid, balance);
            PMS.users.Add(dummy);
            MessageBox.Show("User has benn added.\n The id of the user is:"+userid);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            UserIdBox.Text="";
            BalanceBox.Text="";
        }

        private void SearchInfo_Click(object sender, EventArgs e)
        {
            string medid=MedIdInfoBox.Text;
            listBox1.Items.Clear();
            foreach(Medicine dummy in PMS.medicines)
            {
                if(dummy.MedId==medid)
                {
                    listBox1.Items.Add(dummy.name+ " "+"quantity:"+dummy.quantity+" "+"price:"+dummy.price);
                }
            }
        }

        private void SellMed_Click(object sender, EventArgs e)
        {
            string medid=SellMedIdBox.Text;
            string userid=SellUserIdBox.Text;
            int sellquantity=Convert.ToInt32(SellQuantityBox.Text);

            foreach(User dummy in PMS.users)
            {
                if(dummy.UserId==userid)
                {
                    foreach(Medicine dummyMed in PMS.medicines)
                    {
                        if(dummyMed.MedId==medid)
                        {
                            dummy.Balance=dummy.Balance+dummyMed.price*sellquantity;
                            dummyMed.quantity=dummyMed.quantity-sellquantity;
                        }
                    }
                }
            }

        }

        private void ClearSell_Click(object sender, EventArgs e)
        {
            SellMedIdBox.Text ="";
            SellQuantityBox.Text ="";
            SellUserIdBox.Text ="";
        }

        private void CheckUserIdBox_TextChanged(object sender, EventArgs e)
        {
           string userid=CheckUserIdBox.Text;
            foreach(User dummy in PMS.users)
            {
                if(dummy.UserId==userid)
                {
                    CheckUserBalance.Text=Convert.ToString(dummy.Balance);
                }
            }
        }
    }
}
