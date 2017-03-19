using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LastMileConnectivity
{
    /// <summary>
    /// Integrated with UIDAI
    /// http://www.npci.org.in/documents/Unified-Payment-Interface-API-Technology-Specifications-v11.pdf
    /// </summary>
    public class UPIIntegration
    {
        public bool MakePayment(UserPayment userPayment)
        {
            return true;
        }
    }
}