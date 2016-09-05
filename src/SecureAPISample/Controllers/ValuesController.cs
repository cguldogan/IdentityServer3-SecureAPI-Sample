using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SecureAPISample
{
    public class ValuesController : ApiController
    {
        
        public string Get()
        {
            return "hi anonymous";
        }


        [Authorize] //You need to get token to call this method
        public string Get(int id)
        {
            return id.ToString();
        }

    }
}