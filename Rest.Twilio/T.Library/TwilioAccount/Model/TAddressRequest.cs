using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Library
{
    public class TAddressRequest
    {
        //Address unique id
        public string AddressSid { get; set; }
        //Friendly name
        public string FriendlyName { get; set; }
        //Your name or business name, or that of your customer.
        public string CustomerName { get; set; }
        //The number and street address where you or your customer is located.
        public string Street { get; set; }
        //The city in which you or your customer is located.
        public string City { get; set; }
        //The state or region in which you or your customer is located.
        public string Region { get; set; }
        //The postal code in which you or your customer is located.
        public string PostalCode { get; set; }
        //The ISO country code of your or your customer's address.
        public string IsoCountry { get; set; }
    }
}
