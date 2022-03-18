using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_system_wasif
{
    internal class Loan:Account
    {
        public static int AccountId = 1;
        public double loan;

        public Loan(string name,string id,double loan)
        {
            this.name = name;
            this.id = id;
            this.loan = loan;
        }
    }
}
