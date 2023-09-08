using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bee_app.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    public class InspectionController : ControllerBase
    {
        private static Inspection new_inspection = new Inspection();

        [HttpGet("GetInspection")]

        public ActionResult<Inspection> Get (){
            return Ok(new_inspection);
        }

    }
}