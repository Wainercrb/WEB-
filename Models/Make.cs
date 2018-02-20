using System;
using System.Collections.Generic;

namespace HOMEWORKASP.Models
{
    public class Make
    {
        public int ID { get; set; }
        public string make { get; set; }
        public virtual ICollection<Car> Car {get; set;}
    }
}