using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LastMileConnectivity
{
    public class BookingData
    {
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string SourceLatitude { get; set; }
        public string SourceLongitude { get; set; }
        public string DestinationLatitude { get; set; }
        public string DestinationLongitude { get; set; }
    }
}