using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Library
{
    public abstract class TBase
    {
        // Summary:
        //     Exception encountered during API request
        public TRestException RestException { get; set; }
        
        // Summary:
        //     The URI for this resource, relative to https://api.twilio.com
        public Uri Uri { get; set; }
    }
}
