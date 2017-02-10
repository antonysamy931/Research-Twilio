using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Library
{
    public class TAccount : TBase
    {
        // Summary:
        //     The authorization token for this account. This token should be kept a secret,
        //     so no sharing.
        public string AuthToken { get; set; }
        //
        // Summary:
        //     The date that this account was created, given as GMT
        public DateTime DateCreated { get; set; }
        //
        // Summary:
        //     The date that this account was last updated, given in as GMT
        public DateTime DateUpdated { get; set; }
        //
        // Summary:
        //     A human readable description of this account, up to 64 characters long. By
        //     default the FriendlyName is your email address.
        public string FriendlyName { get; set; }
        //
        // Summary:
        //     A 34 character string that uniquely identifies this account.
        public string Sid { get; set; }
        //
        // Summary:
        //     The status of this account. Usually active, but can be suspended if you've
        //     been bad.
        public string Status { get; set; }
    }
}
