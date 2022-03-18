using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_system_wasif
{
    internal class Current:Account
    {
        public static int AccountId = 1;
        public double MaximumTransaction = 100000;

        public Current(string name,string id,double amount)
        {
            this.name = name;
            this.id = id;
            this.amount = amount;
        }
    }
}
