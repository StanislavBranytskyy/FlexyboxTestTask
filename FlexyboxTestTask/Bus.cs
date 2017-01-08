using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexyboxTestTask
{
    public class Bus : Vehicle
    {
        public int Capacity { get; set; }

        public Bus()
        {
            MaxSpeed = 100;
            Capacity = 12;
            Color = "Yellow";
            Make = "Mercedes";
            Year = 2013;
        }
    }
}
