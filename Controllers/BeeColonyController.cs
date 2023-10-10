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
       public ActionResult<BeeColony> NumBeeColony(
        int Age_of_Queen,
        int Population, 
        int Bee_Type_Class, 
        int Hive_Activity_Class){
        
        return new BeeColony{
            Queen_Age = Age_of_Queen,
            Bee_Population = Population,
            Class_Bee = (BeeTypeClass)Bee_Type_Class,
            Class_Hive = (HiveActivityClass)Hive_Activity_Class
            
        };
       }
    }
}