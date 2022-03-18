using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_management_system
{
    internal class Owner:OwnerInfo
    {
        public Owner(string orderid,string status)
        {
            this.orderid = orderid;
            this.status = status;
        }
    }
}
