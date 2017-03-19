using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LastMileConnectivity.Controllers
{
    public class PaymentController : ApiController
    {

        public string Post(UserPayment user)
        {
            // Calculate Price - Customized Algorithm
            user.BillAmount = new PriceCalculationLogic().GetPriceByDistanceAndTime(user.Distance, user.TimeInMinutes);

            // Get User Details
            user.UAIDI = new AadharIntegration().GetUserUid();

            // Accept Payment
            new UPIIntegration().MakePayment(user);

            return "Payment Successful";
        }

    }
}
