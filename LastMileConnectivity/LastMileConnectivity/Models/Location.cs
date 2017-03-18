using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LastMileConnectivity
{
    public class Location
    {
        public string LocationName { get; set; }
        public string LocationId { get; set; }
    }

    public class Booking
    {
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string MaskedPhoneNumber
        {
            get
            {
                return PhoneNumber.Substring(0, 4) + "XXXXXX";
            }
            set { }
        }
    }

    public class LocationPoint {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}