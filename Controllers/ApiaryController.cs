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
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    public class ApiaryController : ControllerBase
    {
        private static Apiary new_apiary = new Apiary();// Calling the Apiary Class in Models folder

        [HttpGet("GetApiary")]
        public ActionResult<Apiary> Get()// Naming convention of Get is recognised 
        {
            return Ok(new_apiary);
        }

    }
}