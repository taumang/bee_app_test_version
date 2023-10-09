using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using bee_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace bee_app_test_version.Controllers
{   
    [ApiController]
    [Route("api/[controller]/[action]/{id?}")]
    public class BeesAppController : ControllerBase
    {
        //Apiary Controller section
       [HttpGet]
       public ActionResult<Apiary> GetApiary(int id){
        return new Apiary {
            Apiary_Id = id,
            Name = "Ambrosia"
        };
       }

       [HttpPost]
       public ActionResult<Apiary> CreateApiary(Apiary apiary){
            return apiary;
       }

       [HttpPut]
       public ActionResult<Apiary> UpdateApiary(Apiary apiary){
            return apiary;
       }

       [HttpDelete]
       public ActionResult DeleteApiary(int id){
            return Ok();
       }
        
        //BeeColony Controller section
        
   
    }
}