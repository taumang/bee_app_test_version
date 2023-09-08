using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bee_app.Models
{
    public class Inspection
    {
        [Key]
        public int Inspection_Id { get; set; }// Primary Key
        public int BeeColony_Id { get; set; }// Foreign Key

        public BeeColony BeeColony { get; set; } //Navigation to represent relationship

        public DateOnly InspectionDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);// using dateonly to display the date
        public string InspectionTitle { get; set; } = "Was looking for mites";
        public string Observation { get; set; } = "I saw a lot of activity at the entrance of the hive";

        public override string ToString()
        {
            return InspectionDate.ToString();
        }
    }
}