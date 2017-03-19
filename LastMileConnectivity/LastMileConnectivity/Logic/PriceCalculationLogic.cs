using System.Web.Http;

namespace LastMileConnectivity
{
    public class PriceCalculationLogic
    {

        public double GetPriceByDistanceAndTime([FromBody]double distance, double timeInMinutes)
        {
            return 5 + (distance - 0.5) * 5;
        }
    }
}
