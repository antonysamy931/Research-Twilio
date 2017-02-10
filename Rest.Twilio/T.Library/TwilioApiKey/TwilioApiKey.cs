using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.Library.Base;
using Twilio;
using Newtonsoft.Json;
using AutoMapper;

namespace T.Library.TwilioApiKey
{
    public class TwilioApiKey : TTwilioBase
    {
        #region Public Method
        
        public TKey CreateApiKey(string keyName)
        {
            return CreateApikeyDetail(keyName);
        }

        public TKey GetApiKey()
        {
            return GetApiKeyDetail();
        }

        public TKey GetApiKey(string keySid)
        {
            return GetApiKeyDetail(keySid);
        }

        public TKey UpdateApiKey(string keySid, string friendlyName)
        {
            return UpdateApikeyDetail(keySid, friendlyName);
        }

        public bool DeleteApiKey(string keySid)
        {
            return DeleteApikeyDetail(keySid);
        }

        #endregion

        #region Private Method
        
        public TKey CreateApikeyDetail(string keyName)
        {
            Key key = TwilioClient.AddKey(keyName);
            string serialize = JsonConvert.SerializeObject(key);
            File.WriteAllText(@"..\Key.JSON", serialize);
            return Mapper.Map<TKey>(key);
        }

        public TKey GetApiKeyDetail(string keySid = "")
        {
            Key keyValue = null;
            if (string.IsNullOrEmpty(keySid))
            {
                string keyString = File.ReadAllText(@"..\Key.JSON");
                if (!string.IsNullOrEmpty(keyString))
                    keyValue = JsonConvert.DeserializeObject<Key>(keyString);
            }
            else
                keyValue = TwilioClient.GetKey(keySid);
            
            if (keyValue == null)
                throw new Exception("Api key not available");

            if (keyValue != null && keyValue.RestException != null)
                throw new Exception(keyValue.RestException.Message);

            return Mapper.Map<TKey>(keyValue);
        }

        public TKey UpdateApikeyDetail(string keySid, string friendlyName)
        {
            Key keyValue = TwilioClient.UpdateKey(keySid, friendlyName);
            return Mapper.Map<TKey>(keyValue);
        }

        public bool DeleteApikeyDetail(string keySid)
        {
            DeleteStatus status = TwilioClient.DeleteKey(keySid);
            return status == DeleteStatus.Success;
        }
        #endregion
    }
}
