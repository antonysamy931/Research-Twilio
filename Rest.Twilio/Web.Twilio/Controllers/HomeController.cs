using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T.Library;

namespace Web.Twilio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                var lib = new Test();       
            }
            catch (Exception ex)
            {
                throw new HttpException();
            }
            return View();
        }
    }
}
