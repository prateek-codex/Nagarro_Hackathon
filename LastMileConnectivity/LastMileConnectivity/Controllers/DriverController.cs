using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LastMileConnectivity
{
    public class DriverController : ApiController
    {
        public DriverController()
        {
        }

        // GET: api/Driver
        public IEnumerable<Location> Get()
        {
            return null;
        }

        // GET: api/Driver/5
        public IList<Booking> Get(string id)
        {
            IList<Booking> bookingList = new List<Booking>();
            
            // First fetch the location by Id here.
            LocationPoint point = new LocationPoint();

            switch (id)
            {
                case "2":
                    point.Latitude = "28.50141619999999";
                    point.Longitude = "77.07007799999997";
                        
                    break;
                case "1":
                    point.Latitude = "28.4796004";
                    point.Longitude = "77.0798767";
                    break;
                case "3":
                    point.Latitude = "28.5100411";
                    point.Longitude = "77.07214599999998";
                    break;
            }
            
            var index = 0;
            bookingList = new BookingsDAC().GetUserNearToStop(point).Select(x => new Booking() { PhoneNumber = x, UserId = (++index).ToString() }).ToList();

            return bookingList;
        }

        // POST: api/Driver
        public List<Location> Post([FromBody]LocationPoint value)
        {
            var index = 0;
            return new StopsDAC().GetNearByStops(value).Select(x => new Location() { LocationName = x, LocationId = (++index).ToString() }).OrderBy(x => x.LocationName).ToList();

            //return new List<Location>() {
            //         new Location() {
            //             LocationName = "MG Road",
            //             LocationId = "1"
            //         },
            //         new Location() {
            //             LocationName = "Nagarro Plot 14",
            //             LocationId = "2"
            //         }
            //};
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
