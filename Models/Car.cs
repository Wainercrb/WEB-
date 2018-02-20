using System;
using System.Collections.Generic;




namespace HOMEWORKASP.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public int Cylinders { get; set; }

         public virtual Make Make {get; set;}
        
    }
}