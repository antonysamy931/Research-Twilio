using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Library
{
    public class TAddress : TBase
    {

        // Summary:
        //     The unique id of the Account responsible for creating this address.
        public string AccountSid { get; set; }
        //
        // Summary:
        //     Gets or sets the city.
        public string City { get; set; }
        //
        // Summary:
        //     Gets or sets the name of the customer.
        public string CustomerName { get; set; }
        //
        // Summary:
        //     The date that this address was created, given as GMT
        public DateTime DateCreated { get; set; }
        //
        // Summary:
        //     The date that this address was last updated, given as GMT
        public DateTime DateUpdated { get; set; }
        //
        // Summary:
        //     A user provided string that identifies this address.
        public string FriendlyName { get; set; }
        //
        // Summary:
        //     The ISO country code for this address.
        public string IsoCountry { get; set; }
        //
        // Summary:
        //     Gets or sets the postal code.
        public string PostalCode { get; set; }
        //
        // Summary:
        //     Gets or sets the region.
        public string Region { get; set; }
        //
        // Summary:
        //     A 34 character string that uniquely identifies this address.
        public string Sid { get; set; }
        //
        // Summary:
        //     Gets or sets the street component of the address.
        public string Street { get; set; }
    }
}
