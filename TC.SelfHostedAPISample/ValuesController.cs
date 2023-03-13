using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace TC.SelfHostedAPISample
{
    public class ValuesController : ApiController
    {
        public string GetString(Int64 id)
        {
            return "The Id of the given user is " + id;
        }
    }
}
