using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LastMileConnectivity.Controllers
{
    public class IVRController : ApiController
    {
        public void Get()
        {
            new IVRIntegration().Connect();
        }
    }
}
