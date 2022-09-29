using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{    
    public class AddTenController : ApiController
    {
        /// <summary>
        /// returns input number plus 10
        /// </summary>
        /// <param name="id">number to be added 10 to</param>
        /// <returns>
        /// {id}+10
        /// </returns>
        /// Get /api/AddTen/{id}
        /// <example>
        /// Get /api/AddTen/5 ==> 15
        /// </example>
        public int Get(int id)
        {
            int add = id + 10;
            return add;

        }
    }
}
