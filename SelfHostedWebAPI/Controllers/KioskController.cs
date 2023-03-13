using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SelfHostedWebAPI.Controllers
{
    public class KioskController : ApiController
    {
        public string GetString(Int64 id)
        {
            return "The Id of the given kiosk is " + id;
        }
    }
}