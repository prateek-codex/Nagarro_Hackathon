using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECommercePortal
{
    public class DriverController : ApiController
    {
        // GET: api/Driver
        public IEnumerable<Location> Get()
        {
            return new List<Location>() {
                new Location() { LocationName = "MG Road", Users = new List<User>() { new User() { UserId = "1", PhoneNumber = "9654669109"} }}
            };
        }

        // GET: api/Driver/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Driver
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Driver/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Driver/5
        public void Delete(int id)
        {
        }
    }
}
