using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public String Model { get; set; }
        public int CC { get; set; }


        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting..");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is stopping..");
        }
    }
}
