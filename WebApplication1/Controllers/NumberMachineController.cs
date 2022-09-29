using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// returns a number after applying 4 mathematical opertaions to it
        /// </summary>
        /// <param name="id">applies 4 mathematical operations to the {id}</param>
        /// <returns>{id} after applying 4 mathematical operations to it </returns>
        /// Get /api/NumberMachine/{id}
        /// <example>
        /// Get /api/NumberMachine/5 ==> 10
        /// </example>
        public int get(int id)
        {
            int ops=20+((id*4)/2)-20;
            
            return ops;
        }
    }
}
