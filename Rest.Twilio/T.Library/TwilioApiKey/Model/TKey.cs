using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Library
{
    public class TKey : TBase
    {
        // Summary:
        //     The time this Key was created.
        public DateTime DateCreated { get; set; }
        //
        // Summary:
        //     The time this Key was last updated.
        public DateTime DateUpdated { get; set; }
        //
        // Summary:
        //     A human-readable description of this Key.
        public string FriendlyName { get; set; }
        //
        // Summary:
        //     The secret key. Only returned upon the initial creation of the Key resource;
        //     null on subsequent requests.
        public string Secret { get; set; }
        //
        // Summary:
        //     A 34 character string that uniquely identifies this resource.
        public string Sid { get; set; }
    }
}
