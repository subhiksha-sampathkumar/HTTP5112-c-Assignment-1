using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_Demo.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method takes the number of hosted days as an integer input, calculates the number of fortnights, hosting cost, 
        /// HST and total cost and returns these informations in three strings upon receiving a GET request
        /// <example> GET api/HotingCost/5 </example/>
        /// <tests> api/HostingCost/0 returns 1 fortnights at $5.50/FN = $5.50 CAD, HST 13% = $0.72 CAD, Total = $6.22 CAD </tests>
        /// <tests> api/HostingCost/14 returns 2 fortnights at $5.50/FN = $11.00 CAD, HST 13% = $1.43 CAD, Total = $12.43 CAD </tests>
        /// <tests> api/HostingCost/15 returns 2 fortnights at $5.50/FN = $11.00 CAD, HST 13% = $1.43 CAD, Total = $12.43 CAD </tests>
        /// <tests> api/HostingCost/21 returns 2 fortnights at $5.50/FN = $11.00 CAD, HST 13% = $1.43 CAD, Total = $12.43 CAD </tests>
        /// <tests> api/HostingCost/28 returns 3 fortnights at $5.50/FN = $16.50 CAD, HST 13% = $2.14 CAD, Total = $18.64 CAD </tests>
        /// </summary>
        /// <variable> numFN: Number of fortnights, Costing: Hosting Cost, HST: 13% Taxes, TotalCost: Sum of Costing and HST </variable>
        /// <param name="id"></param>
        /// <returns> { numFN + " fortnights at $5.50/FN = $" + Costing.ToString("0.00") + " CAD", "HST 13% = $" + HST.ToString("0.00") + " CAD", "“Total = $" + TotalCost.ToString("0.00") + " CAD" } </returns>

        public IEnumerable<string> Get(int id)

            // id = no. of days
        {
            decimal numFN, Costing, HST, TotalCost;

            numFN = (decimal)(id + 1) / 14;

            numFN = Math.Ceiling(numFN);

            Costing = (decimal)5.5 * numFN;

            HST = (decimal)0.13 * Costing;

            TotalCost = Costing + HST;

            return new string[] { numFN + " fortnights at $5.50/FN = $" + Costing.ToString("0.00") + " CAD", "HST 13% = $" + HST.ToString("0.00") + " CAD", "“Total = $" + TotalCost.ToString("0.00") + " CAD" }; 
        }
    }
}
