using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace T.Library.Base
{
    public abstract class TTwilioBase : ConfigurationReader
    {

        public TwilioRestClient TwilioClient = null;

        private static bool CheckActive = false;

        public TTwilioBase()
        {
            TwilioClient = new TwilioRestClient(Account_SID, Auth_Token);

            if (!CheckActive)
            {
                Validate();
                InitializeMapper();
            }
        }

        protected virtual void Validate()
        {
            Account account = TwilioClient.GetAccount();
            if (account.RestException != null)
            {
                if (account.RestException.Status == "401")
                    throw new UnauthorizedAccessException(account.RestException.Message);
            }
            CheckActive = true;
        }

        protected virtual void InitializeMapper()
        {
            Mapper.CreateMap<Account, TAccount>();
            Mapper.CreateMap<RestException, TRestException>();
            Mapper.CreateMap<Address, TAddress>();
            Mapper.CreateMap<Application, TApplication>();
            Mapper.CreateMap<TApplicationRequest, ApplicationOptions>();
            Mapper.CreateMap<Key, TKey>();
        }
    }
}
