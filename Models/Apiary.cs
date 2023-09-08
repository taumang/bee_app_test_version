
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace bee_app.Models
{
    public class Apiary
    {
        [Key]
        public int Apiary_Id { get; set; }
        public string Name { get; set; } = "Ambrosia";
        public string Location { get; set; } = "Bronkhorstspruit";
        public DateOnly EstablishedDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);  
        //Displaying the date as a string
        

    }
}