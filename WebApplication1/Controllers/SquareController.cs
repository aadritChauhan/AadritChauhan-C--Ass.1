using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// returns square of the input number
        /// </summary>
        /// <param name="id">number to be squared </param>
        /// <returns>Square of {id} </returns>
        /// Get /api/Square/{id}
        /// <example>
        /// Get /api/Square/5 ==> 25
        /// </example>
        public int get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
