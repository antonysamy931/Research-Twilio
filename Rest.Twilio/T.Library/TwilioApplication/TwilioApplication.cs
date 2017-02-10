using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.Library.Base;
using Twilio;

namespace T.Library.TwilioApplication
{
    public class TwilioApplication : TTwilioBase
    {
        #region Public Method
        
        public List<TApplication> GetApplications()
        {
            return GetApplicationDetails();
        }

        public List<TApplication> GetApplications(string applicationName)
        {
            return GetApplicationDetails(applicationName);
        }
        
        public TApplication GetApplication(string applicationSid)
        {
            return GetApplicationDetail(applicationSid);
        }

        public TApplication CreateApplication(string applicationName, TApplicationRequest options)
        {
            return CreateApplicationDetail(applicationName, options);
        }

        public TApplication UpdateApplication(string applicationName, string applicationSid, TApplicationRequest options)
        {
            return UpdateApplicationDetail(options, applicationSid, applicationName);
        }

        public bool DeletApplication(string applicationSid)
        {
            return DeleteApplicationDetail(applicationSid);
        }

        #endregion

        #region Private Method

        private List<TApplication> GetApplicationDetails(string application = "")
        {
            List<Application> applications = TwilioClient.ListApplications(string.IsNullOrEmpty(application) ? null : application, null, null).Applications;
            return Mapper.Map<List<TApplication>>(applications);
        }

        private TApplication GetApplicationDetail(string applicationSid)
        {
            Application application = TwilioClient.GetApplication(applicationSid);
            return Mapper.Map<TApplication>(application);
        }

        private TApplication CreateApplicationDetail(string friendlyName, TApplicationRequest applicationRequest)
        {
            ApplicationOptions options = Mapper.Map<ApplicationOptions>(applicationRequest);
            Application application = TwilioClient.AddApplication(friendlyName, null);      
            if (application.RestException != null)
                throw new Exception(application.RestException.Message);
            return Mapper.Map<TApplication>(application);
        }

        private TApplication UpdateApplicationDetail(TApplicationRequest applicationRequest, string applicationSid, string friendlyName)
        {
            ApplicationOptions options = Mapper.Map<ApplicationOptions>(applicationRequest);
            Application application = TwilioClient.UpdateApplication(applicationSid, friendlyName, options);
            if (application.RestException != null)
                throw new Exception(application.RestException.Message);
            return Mapper.Map<TApplication>(application);
        }

        private bool DeleteApplicationDetail(string applicationSid)
        {
            DeleteStatus status = TwilioClient.DeleteApplication(applicationSid);
            return status == DeleteStatus.Success;
        }

        #endregion
    }
}
