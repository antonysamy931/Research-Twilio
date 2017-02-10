using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T.Library;
using T.Library.TwilioAccount;

namespace Web.Twilio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                var lib = new TwilioAccount().GetAccount();       
            }
            catch (Exception ex)
            {
                throw new HttpException();
            }
            return View();
        }
    }
}
