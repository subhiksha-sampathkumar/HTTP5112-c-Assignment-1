using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_Demo.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method takes an integer input and returns a string,greeting the input number of people, upon receiving a Get request
        /// <example> GET api/Greeting/5 </example>
        /// <tests> api/Greeting/3 returns Greetings to 3 people </tests>
        /// <tests> api/Greeting/6 returns Greetings to 6 people </tests>
        /// <tests> api/Greeting/0 returns Greetings to 0 people </tests>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> "Greetings to " + id + " people!" </returns>

     
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }


        /// <summary>
        /// This method returns the string "Hello world" upon receiving a Post request 
        /// <example> POST api/Greeting/PostA </example>
        /// <tests> api/Greeting/PostA returns "Hello World" 
        /// in command prompt window: curl -d "" "http://localhost:50125/api/Greeting/PostA" returns "Hello World"</tests>
        /// </summary>
        /// <returns> "Hello World!" </returns>


        public string PostA()
        {
            return "Hello World!";
        }
    }
}
