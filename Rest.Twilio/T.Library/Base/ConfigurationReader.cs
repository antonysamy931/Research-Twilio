using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace T.Library.Base
{
    public abstract class ConfigurationReader
    {
        private const string SID = "Account.SID";
        private const string AuthToken = "Auth.Token";

        public string Account_SID
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings[SID].ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception(string.Format("'{0}' key not found.", SID));
                }
            }
        }

        public string Auth_Token
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings[AuthToken].ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception(string.Format("'{0}' key not found.", AuthToken));
                }
            }
        }
    }
}
