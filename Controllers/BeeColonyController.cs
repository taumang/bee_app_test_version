using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using bee_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bee_app_test_version.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    public class BeeColonyController : Controller
    {
      [HttpGet]
       public ActionResult<BeeColony> GetBeeColony(int id){
        return new BeeColony {
            BeeColony_Id = id
        };
       }
       [HttpPost]
       public ActionResult<BeeColony> numBeeColony(int Age_of_Queen,int Population, int BeeTypeClass, int HiveActivityClass){
        return new BeeColony{
            QueenAge = Age_of_Queen,
            BeePopulation = Population,
            Class_Bee = (BeeTypeClass)BeeTypeClass,
            Class_Hive = (HiveActivityClass)HiveActivityClass
            
        };
       }
    }
}