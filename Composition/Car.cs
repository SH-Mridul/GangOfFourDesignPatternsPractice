using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class Car
    {
        private Chassis _chassis = new();
        private Engine _engine = new();
        private Wheels _wheels = new();
        private Seats _seat = new();




        public void StartCar()
        {
            _chassis.Support();
            _engine.Start();
            _seat.Sit();
            _wheels.Rotate();

            Console.WriteLine("Car Started.");
        }
    }
}
