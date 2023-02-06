using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_Demo.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// This method takes an integer input and performs 4 mathematical operatins and returns the number upen recieiving a Get request
        /// <example> GET api/NumberMachine/5 </example>
        /// <tests> api/NumberMachine/10 returns 19</tests>
        /// <tests> api/NumberMachine/-5 returns -11</tests>
        /// <tests> api/NumberMachine/30 returns 59</tests>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> (((id * id) - id) / id) + id </returns>


        public int Get(int id)
        {
            return (((id * id) - id) / id) + id;
        }
    }
}
