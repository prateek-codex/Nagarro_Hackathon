﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ECommercePortal
{
    public class Location
    {
        public string LocationName { get; set; }

        public List<User> Users { get; set; }
    }

    public class User
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
}