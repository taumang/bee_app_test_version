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

        public BeeColony Bee_Colony { get; set; } //Navigation to represent relationship

        public DateOnly Inspection_Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);// using dateonly to display the date
        public string Inspection_Title { get; set; } = "Was looking for mites";
        public string Observation { get; set; } = "I saw a lot of activity at the entrance of the hive";

        public override string ToString()
        {
            return Inspection_Date.ToString();
        }
    }
}