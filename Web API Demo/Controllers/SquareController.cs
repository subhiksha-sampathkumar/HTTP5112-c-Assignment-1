using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_Demo.Controllers
{
    public class SquareController : ApiController
    {

        /// <summary>
        /// This method takes an integer input and returns the square of the number when receiving a Get request
        /// <example> GET api/Square/5 </example>
        /// <tests> api/Square/2 returns 4</tests>
        /// <tests> api/Square/-2 returns 4</tests>
        /// <tests> api/Addten/10 returns 100</tests>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> id * id </returns>

        public int Get(int id)
        {
            return id * id;
        }
         
    }
}
