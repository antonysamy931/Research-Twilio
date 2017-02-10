using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Library
{
    public class TApplication : TBase
    {
        // Summary:
        //     The unique id of the Account responsible for this phone number.
        public string AccountSid { get; set; }
        //
        // Summary:
        //     Calls to this phone number will start a new TwiML session with this API version.
        public string ApiVersion { get; set; }
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
        //     The HTTP method Twilio will use when requesting the above URL. Either GET
        //     or POST.
        public string SmsFallbackMethod { get; set; }
        //
        // Summary:
        //     The URL that Twilio will request if an error occurs retrieving or executing
        //     the TwiML from SmsUrl.
        public string SmsFallbackUrl { get; set; }
        //
        // Summary:
        //     The HTTP method Twilio will use when making requests to the SmsUrl. Either
        //     GET or POST.
        public string SmsMethod { get; set; }
        //
        // Summary:
        //     The URL that Twilio will request to pass status parameters (such as call
        //     ended) to your application.
        public string SmsStatusCallback { get; set; }
        //
        // Summary:
        //     The URL Twilio will request when receiving an incoming SMS message to this
        //     number.
        public string SmsUrl { get; set; }
        //
        // Summary:
        //     The URL that Twilio will request to pass status parameters (such as call
        //     ended) to your application.
        public string StatusCallback { get; set; }
        //
        // Summary:
        //     Twilio will make a POST request to this URL to pass status parameters (such
        //     as sent or failed) to your application if you specify this application's
        //     Sid as the ApplicationSid on an outgoing SMS request.
        public string StatusCallbackMethod { get; set; }
        //
        // Summary:
        //     Look up the caller's caller-ID name from the CNAM database (additional charges
        //     apply)
        public bool VoiceCallerIdLookup { get; set; }
        //
        // Summary:
        //     The HTTP method Twilio will use when requesting the VoiceFallbackUrl. Either
        //     GET or POST.
        public string VoiceFallbackMethod { get; set; }
        //
        // Summary:
        //     The URL that Twilio will request if an error occurs retrieving or executing
        //     the TwiML requested by Url.
        public string VoiceFallbackUrl { get; set; }
        //
        // Summary:
        //     The HTTP method Twilio will use when requesting the above Url. Either GET
        //     or POST.
        public string VoiceMethod { get; set; }
        //
        // Summary:
        //     The URL Twilio will request when this phone number receives a call.
        public string VoiceUrl { get; set; }
    }
}
