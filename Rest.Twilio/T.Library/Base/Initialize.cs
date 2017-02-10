using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace T.Library.Base
{
    public abstract class Initialize : ConfigurationReader
    {

        public TwilioRestClient TwilioClient = null;

        public Initialize()
        {
            TwilioClient = new TwilioRestClient(Account_SID, Auth_Token);
            Validate();
        }

        void Validate()
        {
            Account account = TwilioClient.GetAccount();
            if (account.RestException != null)
            {
                if (account.RestException.Status == "401")
                    throw new UnauthorizedAccessException(account.RestException.Message);
            }
        }
    }
}
