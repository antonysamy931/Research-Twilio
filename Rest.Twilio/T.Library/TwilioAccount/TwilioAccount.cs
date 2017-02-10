using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.Library.Base;
using Twilio;

namespace T.Library.TwilioAccount
{
    public class TwilioAccount : TTwilioBase
    {
        #region Account
        public TAccountDetail GetAccount()
        {
            return GetAccountDetail();
        }

        public TAccountDetail GetAccount(string accountSid)
        {
            return GetAccountDetail(accountSid);
        }

        public TAccount UpdateAccountName(string changedName)
        {
            return UpdateAccountNameDetail(changedName);
        }
        #endregion

        #region Sub Accounts

        public List<TAccount> GetSubAccounts()
        {
            return GetSubAccountDetails();
        }

        public TAccount GetSubAccount(string accountSid)
        {
            return GetAccountInfo(accountSid);
        }

        public TAccount SuspendSubAccount(string accountSid)
        {
            return ChangeSubAccountStatus(accountSid, AccountStatus.Suspended);
        }

        public TAccount ActiveSubAccount(string accountSid)
        {
            return ChangeSubAccountStatus(accountSid, AccountStatus.Active);
        }

        public TAccount CloseSubAccount(string accountSid)
        {
            return ChangeSubAccountStatus(accountSid, AccountStatus.Closed);
        }

        #endregion

        #region Address
        public List<TAddress> GetAddresses()
        {
            return GetAddressDetails();
        }

        public TAddress GetAddress(string addressSid)
        {
            return GetAddressDetail(addressSid);
        }

        public TAddress CreateAddress(TAddressRequest request)
        {
            return CreateAddress(request);
        }

        public TAddress UpdateAddress(TAddressRequest request)
        {
            return UpdateAddressDetail(request);
        }

        public bool DeleteAddress(string addressSid)
        {
            return DeleteAddressDetail(addressSid);
        }
        #endregion

        #region Private Method

        private TAccountDetail GetAccountDetail(string accountSid = "")
        {
            TAccountDetail model = new TAccountDetail();
            model.Account = GetAccountInfo(accountSid);
            model.Addresses = GetAddressDetails();
            return model;
        }

        private List<TAddress> GetAddressDetails()
        {
            List<Address> addresses = TwilioClient.ListAddresses().Addresses;
            return Mapper.Map<List<TAddress>>(addresses);
        }

        private TAccount GetAccountInfo(string accountSid = "")
        {
            Account account = string.IsNullOrEmpty(accountSid) ? TwilioClient.GetAccount() : TwilioClient.GetAccount(accountSid);
            if (account.RestException != null)
                throw new Exception(account.RestException.Message);
            return Mapper.Map<TAccount>(account);
        }

        private TAddress CreateAddressDetail(TAddressRequest address)
        {
            Address addressModel = TwilioClient.AddAddress(address.FriendlyName, address.CustomerName, address.Street, address.City, address.Region, address.PostalCode, address.IsoCountry);
            if (addressModel.RestException != null)
                throw new Exception(addressModel.RestException.Message);
            return Mapper.Map<TAddress>(addressModel);
        }

        private TAddress GetAddressDetail(string addressSid)
        {
            Address detail = TwilioClient.GetAddress(addressSid);
            if (detail.RestException != null)
                throw new Exception(detail.RestException.Message);
            return Mapper.Map<TAddress>(detail);
        }

        private TAddress UpdateAddressDetail(TAddressRequest address)
        {
            AddressOptions addressOptions = new AddressOptions()
            {
                City = address.City,
                CustomerName = address.CustomerName,
                FriendlyName = address.FriendlyName,
                PostalCode = address.PostalCode,
                Region = address.Region,
                Street = address.Street
            };
            Address detail = TwilioClient.UpdateAddress(address.AddressSid, addressOptions);
            if (detail.RestException != null)
                throw new Exception(detail.RestException.Message);
            return Mapper.Map<TAddress>(detail);
        }

        private bool DeleteAddressDetail(string addressSid)
        {
            DeleteStatus status = TwilioClient.DeleteAddress(addressSid);
            return status == DeleteStatus.Success;
        }

        private TAccount UpdateAccountNameDetail(string friendlyName)
        {
            Account account = TwilioClient.UpdateAccountName(friendlyName);
            if (account.RestException != null)
                throw new Exception(account.RestException.Message);
            return Mapper.Map<TAccount>(account);
        }

        private TAccount CreateSubAccountDetail(string friendlyName)
        {
            Account account = TwilioClient.CreateSubAccount(friendlyName);
            if (account.RestException != null)
                throw new Exception(account.RestException.Message);
            return Mapper.Map<TAccount>(account);
        }

        private List<TAccount> GetSubAccountDetails()
        {
            List<Account> accounts = TwilioClient.ListSubAccounts().Accounts;
            return Mapper.Map<List<TAccount>>(accounts);
        }

        private TAccount ChangeSubAccountStatus(string accountSid, AccountStatus status)
        {
            Account account = TwilioClient.ChangeSubAccountStatus(accountSid, status);
            if (account.RestException != null)
                throw new Exception(account.RestException.Message);
            return Mapper.Map<TAccount>(account);
        }
        
        #endregion
    }
}
