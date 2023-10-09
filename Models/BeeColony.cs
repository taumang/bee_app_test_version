using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bee_app.Models
{
    public class BeeColony
    {   
       
        [Key]
        public int BeeColony_Id { get; set; }        
        public int Apiary_Id { get; set; }

         public Apiary? Apiary { get; set; }
        
        public int queenAge;
        public int QueenAge { 
            get
            {
            return queenAge;
            }
             set
             {
            // value does not go over 6
            if (value <= 6)
                    queenAge = value;
            else
                // if 6 is reach or goes over 6, set it to the maximum allowed value (6)
                queenAge = 6;
             }
            }
        public BeeTypeClass Class_Bee { get; set; } = BeeTypeClass.African_Killer_Bee;
        public int BeePopulation { get; set; }
        public HiveActivityClass Class_Hive { get; set; } = HiveActivityClass.Active; // Enum
        public DateOnly DateLastInspected { get; set; } = DateOnly.FromDateTime(DateTime.Now); 

        public override string ToString()
        {
            return DateLastInspected.ToString();
        }
    }
}