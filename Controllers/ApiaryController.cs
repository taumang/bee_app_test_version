global using bee_app.Models;
global using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bee_app.Controllers
{
    [ApiController]
    /* used the 'Microsoft.AspNetCore.Components' to remove error on the route, it is regarded as an ambiguous reference */
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    public class ApiaryController : ControllerBase
    {
        // Calling the Apiary Class in Models folder
        private static List<Apiary> new_apiary = new List<Apiary>{
            new Apiary(),
            new Apiary {Name = "Aphrodite"},
            new Apiary {Location = "Greece"}
        };


        [HttpGet("GetApiary")]
        public ActionResult<List<Apiary>> Get()// Naming convention of Get is recognized 
        {
            return Ok(new_apiary);
        }

    }
}