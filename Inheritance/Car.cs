using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car:Vehicle
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }

        public override void Start()
        {
            Console.WriteLine(Model + " is starting..");
        }

        public override void Stop()
        {
            Console.WriteLine(Model + " is stopping...");
        }
    }
}
