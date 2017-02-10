using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Library
{
    public class TAccountDetail : TBase
    {
        //  Summary
        //Account information for twilio account
        public TAccount Account { get; set; }

        //  Summary
        //List of address
        public List<TAddress> Addresses { get; set; }

        //  Summary
        //List of sub accounts
        public List<TAccount> SubAccount { get; set; }
    }
}
