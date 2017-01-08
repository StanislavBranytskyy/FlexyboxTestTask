using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexyboxTestTask
{
    public abstract class Vehicle
    {
        public int MaxSpeed { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
    }
}
