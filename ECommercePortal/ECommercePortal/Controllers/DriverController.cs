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
        public DriverController()
        {
        }

        // GET: api/Driver
        public IEnumerable<Location> Get()
        {
            return new List<Location>() {
                     new Location() {
                         LocationName = "MG Road",
                         LocationId = "1"
                     },
                     new Location() {
                         LocationName = "Nagarro Plot 14",
                         LocationId = "2"
                     }
            };
        }

        // GET: api/Driver/5
        public IList<Booking> Get(string id)
        {
            IList<Booking> bookingList = new List<Booking>();

            switch (id)
            {
                case "1":
                    bookingList = new List<Booking>() {
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887825", UserId = "1" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887826", UserId = "2" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887827", UserId = "3" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887828", UserId = "4" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887829", UserId = "5" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887821", UserId = "6" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887822", UserId = "7" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887823", UserId = "8" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887824", UserId = "9" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887825", UserId = "10" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887826", UserId = "11" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887827", UserId = "12" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887828", UserId = "13" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887829", UserId = "14" },
                         };
                    break;
                case "2":
                default: bookingList = new List<Booking>() {
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887830", UserId = "15" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887826", UserId = "2" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887827", UserId = "3" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887828", UserId = "4" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887829", UserId = "5" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887821", UserId = "6" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887822", UserId = "7" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887823", UserId = "8" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887824", UserId = "9" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887825", UserId = "10" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887826", UserId = "11" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887827", UserId = "12" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887828", UserId = "13" },
                             new Booking() {MaskedPhoneNumber = "9868XXXXXX", PhoneNumber="9868887829", UserId = "14" },
                         };
                    break;
            }

            return bookingList;
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
