using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bee_app.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    public class BeeColonyController : ControllerBase
    {
        private static BeeColony new_colony = new BeeColony();

        [HttpGet("GetColony")]
        public ActionResult<BeeColony> Get() 
        {
            return Ok(new_colony);
        }
    }
}