using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=NameBox.Text;
            string id=Convert.ToString(User.orderid)+"400";
            User.orderid++;
            string address=AddressBox.Text;

            User dummy=new User(name,id,address);
            LMS.users.Add(dummy);
            MessageBox.Show("User has been added"+"\n"+"your id is"+id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameBox.Text ="";
            AddressBox.Text ="";
            IdBox.Text ="";
        }

        private void Order_Click(object sender, EventArgs e)
        {

            string id = OrderIDPlaceOrder.Text;
            foreach(User dummy in LMS.users)
            {
                if(id==dummy.id)
                {
                    dummy.shirt=Convert.ToInt32(ShirtBox.Text);
                    dummy.pant=Convert.ToInt32(PantBox.Text);
                    dummy.suit=Convert.ToInt32(SuitBox.Text);
                    dummy.bed=Convert.ToInt32(BedBox.Text);
                    //shirt status price
                    if(ShirtCombo.Text=="Wash")
                    {
                        dummy.ShirtStat=5;
                    }
                    else if(ShirtCombo.Text=="Iron")
                    {
                        dummy.ShirtStat=7;
                    }
                    else if(ShirtCombo.Text =="Both")
                    {
                        dummy.ShirtStat=10;
                    }
                    //pant status price
                    if (PantCombo.Text=="Wash")
                    {
                        dummy.PantStat=5;
                    }
                    else if (PantCombo.Text=="Iron")
                    {
                        dummy.PantStat=7;
                    }
                    else if (PantCombo.Text =="Both")
                    {
                        dummy.PantStat=10;
                    }
                    //suit status price
                    if (SuitCombo.Text=="Wash")
                    {
                   
                        dummy.suitstat=7;
                    }
                  
                    else if(SuitCombo.Text=="Iron")
                    {
                        dummy.suitstat=10;
                    }
                    else if (SuitCombo.Text =="Both")
                    {
                        dummy.suitstat=15;
                    }
                    //bed status price
                    if (BedCombo.Text=="Wash")
                    {

                        dummy.BedStat=15;
                    }

                    else if (BedCombo.Text=="Iron")
                    {
                        dummy.BedStat=17;
                    }
                    else if (BedCombo.Text =="Both")
                    {
                        dummy.BedStat=20;
                    }
                    MessageBox.Show("Order has been added");

                }
            }    
        }

        private void SeeStatus_Click(object sender, EventArgs e)
        {
            string id=OwnerOrderIdBox.Text;
            string status=OrderCombo.Text;
            foreach(User dummy in LMS.users)
            {
                if(id==dummy.id)
                {
                    BalanceOutputBox.Text=Convert.ToString(dummy.Balance(dummy.shirt,dummy.pant,dummy.suit,
                        dummy.bed,dummy.ShirtStat,dummy.PantStat,dummy.suitstat,dummy.BedStat));
                    
                    Owner dummyOwner=new Owner(id,status);
                    LMS.owners.Add(dummyOwner);
                    
                   

                }
            }
        }

        private void Information_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string id = UserInformationId.Text;
            foreach(User dummy in LMS.users)
            {
                if(id==dummy.id)
                {
                    NameOutputBox.Text=dummy.name;
                    AddressOutputBox.Text=dummy.address;
                    AmountOutputBox.Text=Convert.ToString(dummy.Balance(dummy.shirt, dummy.pant, dummy.suit,
                        dummy.bed, dummy.ShirtStat, dummy.PantStat, dummy.suitstat, dummy.BedStat));

                    listBox1.Items.Add(dummy.info(dummy.shirt,dummy.pant,dummy.suit,dummy.bed));
                    
                    
                }
            }
            foreach(Owner dummy in LMS.owners)
            {
             if(id==dummy.orderid)
                {
                    StatusOutputBox.Text=dummy.status;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PantBox.Text="";
            ShirtBox.Text="";
            SuitBox.Text= "";
            BedBox.Text="";
        }
    }
}
