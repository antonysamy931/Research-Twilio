using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Library
{
    public class TApplicationRequest
    {
        // Summary:
        //     The HTTP method that should be used to request the SmsFallbackUrl. Must be
        //     either GET or POST. Defaults to POST.
        public string SmsFallbackMethod { get; set; }
        //
        // Summary:
        //     A URL that Twilio will request if an error occurs requesting or executing
        //     the TwiML defined by SmsUrl.
        public string SmsFallbackUrl { get; set; }
        //
        // Summary:
        //     The HTTP method that should be used to request the SmsUrl. Must be either
        //     GET or POST. Defaults to POST.
        public string SmsMethod { get; set; }
        //
        // Summary:
        //     Twilio will make a POST request to this URL to pass status parameters (such
        //     as sent or failed) to your application if you specify this application's
        //     Sid as the ApplicationSid on an outgoing SMS request.
        public string SmsStatusCallback { get; set; }
        //
        // Summary:
        //     The URL that Twilio should request when somebody sends an SMS to the phone
        //     number using this application.
        public string SmsUrl { get; set; }
        //
        // Summary:
        //     The URL that Twilio will request to pass status parameters (such as call
        //     ended) to your application.
        public string StatusCallback { get; set; }
        //
        // Summary:
        //     The HTTP method Twilio will use to make requests to the StatusCallback URL.
        //     Either GET or POST. Defaults to POST.
        public string StatusCallbackMethod { get; set; }
        //
        // Summary:
        //     Do a lookup of a caller's name from the CNAM database and post it to your
        //     app. Either true or false. Defaults to false.
        public bool? VoiceCallerIdLookup { get; set; }
        //
        // Summary:
        //     The HTTP method that should be used to request the VoiceFallbackUrl. Either
        //     GET or POST. Defaults to POST.
        public string VoiceFallbackMethod { get; set; }
        //
        // Summary:
        //     A URL that Twilio will request if an error occurs requesting or executing
        //     the TwiML at Url.
        public string VoiceFallbackUrl { get; set; }
        //
        // Summary:
        //     The HTTP method that should be used to request the VoiceUrl. Must be either
        //     GET or POST. Defaults to POST.
        public string VoiceMethod { get; set; }
        //
        // Summary:
        //     The URL that Twilio should request when somebody dials the a phone number
        //     using this application.
        public string VoiceUrl { get; set; }
    }
}
