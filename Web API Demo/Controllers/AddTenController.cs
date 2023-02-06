using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_Demo.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method takes a integer input and returns and adds 10 to the number and returns it
        /// <example>  GET api/AddTen/5 </example>
        /// <tests> api/Addten/21 returns 31</tests>
        /// <tests> api/Addten/0 returns 10</tests>
        /// <tests> api/Addten/-9 returns 1</tests>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>




        public int Get(int id)
        {
            return id + 10;
        }

    }
}
