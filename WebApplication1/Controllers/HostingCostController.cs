using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// computes the hosting cost
        /// </summary>
        /// <param name="id">The input {id} represents the number of days which has elapsed since the beginning of the hosting</param>
        /// <returns>
        ///  cost(according to fortnights)
        ///  tax(13% on the cost)
        ///  totalCost(cost+tax)
        /// </returns>
        /// <example>
        /// GET .../HostingCost/14==>
        /// 
        /// 2 fortnights at $5.50/FN = $11.00 CAD 
        /// HST 13% = $1.43 CAD 
        /// Total = $12.43 CAD
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            int days = id;
            int fortnights = (days / 14)+1;
            double cost= fortnights*5.5;
            double tax = (0.13) * cost;
            double totalCost = tax + cost;
            return new string[] { "1 fortnight at $5.50/FN=" + cost + "CAD", "HST 13% = " + tax, "Total=" + totalCost + "CAD" };
        }
       
    }
}
