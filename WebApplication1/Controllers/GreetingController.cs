using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class GreetingController : ApiController
    {    
        
        public void Post([FromBody] string id)
        {
        }
        /// <summary>
        /// Displays "Hello World!"
        /// </summary>
        /// POST /api/Greeting
        /// <returns>
        /// POST /api/Greeting
        /// </returns>
        /// <example> 
        /// POST /api/Greeting ==> Hello World!
        /// </example>
        public string Get()
        {
          return "Hello World!";
        }

        /// <summary>
        /// returns Greetings to {id} people!
        /// </summary>
        /// <param name="id"> </param>
        /// <returns>Greetings to {id} people! </returns>
        /// Get /api/Greeting/{id}
        /// <example>
        /// Get /api/Greeting/5 ==>  Greetings to 5 people!
        /// </example>
        public string Get(int id)
        {
            return "Greetings to " +id+ " people!";
        }


    }
}
