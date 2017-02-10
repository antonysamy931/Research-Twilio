using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Library
{
    // Summary:
    //     Exceptions returned in the HTTP response body when something goes wrong.
    public class TRestException
    {        

        // Summary:
        //     (Conditional) An error code to find help for the exception.
        public string Code { get; set; }
        //
        // Summary:
        //     A more descriptive message regarding the exception.
        public string Message { get; set; }
        //
        // Summary:
        //     (Conditional) The URL of Twilio's documentation for the error code.
        public string MoreInfo { get; set; }
        //
        // Summary:
        //     The HTTP status code for the exception.
        public string Status { get; set; }
    }
}
