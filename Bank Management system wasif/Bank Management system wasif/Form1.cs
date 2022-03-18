using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_system_wasif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SavingAccountRadio.Checked==true)
            {
                string name=NameBox.Text;
                string id=Saving.AccountId.ToString()+"314";
                Saving.AccountId++;
                double deposit=Convert.ToDouble(BalanceBox.Text);
                if(deposit<500)
                {
                    MessageBox.Show("Please deposit at least 500 taka");
                }
                else 
                {
                    Saving dummy = new Saving(name, id, deposit);
                    Bank.savings.Add(dummy);
                    MessageBox.Show("Account has been added"+"your id is:"+id);
                }
                }

            else if(LoanAccountRadio.Checked==true)
            {
                string name = NameBox.Text;
                string id = Loan.AccountId.ToString()+"400";
                Loan.AccountId++;
                double loan = Convert.ToDouble(BalanceBox.Text);
                loan=loan*0.9+loan;
                Loan dummy = new Loan(name, id, loan);
                Bank.loans.Add(dummy);
                MessageBox.Show("Account has been added"+id);

            }
            else if(CurrentAccountRadio.Checked==true)
            {
               string name=NameBox.Text;
               string id=Current.AccountId.ToString()+"300";
               Current.AccountId++;
               double deposit = Convert.ToDouble(BalanceBox.Text);
                if(deposit < 500)
                {
                    MessageBox.Show("Please, deposit at least 500 taka");
                }
                else
                {
                    Current dummy=new Current(name, id, deposit);
                    Bank.currents.Add(dummy);
                    MessageBox.Show("Account has been added"+id);
                }
                
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(SavingDepositRadio.Checked==true)
            {
                string id = DepositId.Text;
                double deposit=Convert.ToDouble(Deposit.Text);
                
                foreach(Saving dummy in Bank.savings)
                {
                    if(id==dummy.id)
                    {
                       dummy.amount+=deposit;
                        MessageBox.Show("Your money has been deposited.");
                    }

                }
            }
            else if (LoanDepositRadio.Checked==true)
            {
                string id=DepositId.Text;
                double deposit= Convert.ToDouble(Deposit.Text);
                foreach (Loan dummy in Bank.loans)
                {
                    if(id==dummy.id)
                    {
                        dummy.loan-=deposit;
                        MessageBox.Show("Your money has been deposited.");
                    }
                }    
            }
            else if(CurrentDepositRadio.Checked==true)
            {
                string id = DepositId.Text;
                double deposit=Convert.ToDouble(Deposit.Text);

                foreach(Current dummy in Bank.currents)
                {
                    if(dummy.id==id)
                    {
                        dummy.amount+=deposit;
                        MessageBox.Show("Your money has been deposited.");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(SavingWithdrawRadio.Checked==true)
            {
                string id=WithdrawId.Text;
                double withdraw=Convert.ToDouble(Withdraw.Text);
                foreach(Saving dummy in Bank.savings)
                {
                    if(id==dummy.id)
                    {
                        if(withdraw>dummy.amount)
                        {
                            MessageBox.Show("Cannot withdraw money");
                        }
                        else 
                        {
                            dummy.amount-=withdraw;
                            MessageBox.Show("Your money has been withdrawn.");
                        }
                    }
                }

            }
            else if(LoanWithdrawRadio.Checked==true)
            {
                string id = WithdrawId.Text;
                double withdraw= Convert.ToDouble(Withdraw.Text);
                foreach(Loan dummy in Bank.loans)
                {
                    if(id==dummy.id)
                    {
                        dummy.loan+=withdraw;
                        MessageBox.Show("Your money has been withdrawn.");
                    }
                }

            }
            else if(CurrentWithdrawRadio.Checked ==true)
            {
                string id = WithdrawId.Text;
                double withdraw = Convert.ToDouble(Withdraw.Text);
                foreach(Current dummy in Bank.currents)
                {
                    if(id==dummy.id)
                    {
                        if(withdraw>dummy.amount)
                        {
                            MessageBox.Show("Does not have sufficient balance");
                        }
                        else
                        {
                            dummy.amount -= withdraw;
                            MessageBox.Show("Your money has been withdrawn.");
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(SavingInformationRadio.Checked==true)
            {
                string id=InformationId.Text;
                foreach(Saving dummy in Bank.savings)
                {
                    if(id==dummy.id)
                    {
                        NameOutput.Text=dummy.name;
                        BalanceOutputBox.Text=Convert.ToString(dummy.amount);
                    }
                }
            }
            else if(LoanInformationRadio.Checked==true)
            {
                string id = InformationId.Text;
                foreach(Loan dummy in Bank.loans)
                {
                    NameOutput.Text=dummy.name;
                    BalanceOutputBox.Text=Convert.ToString(dummy.loan);

                }
            }
            else if(CurrentInformationRadio.Checked==true)
            {
                string id = InformationId.Text;
                foreach (Current dummy in Bank.currents)
                {
                    NameOutput.Text=dummy.name;
                    BalanceOutputBox.Text=Convert.ToString(dummy.amount);

                }

            }
        }
    }
}
