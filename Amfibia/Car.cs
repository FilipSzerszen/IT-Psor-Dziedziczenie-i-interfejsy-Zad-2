using System;
using System.Collections.Generic;
using System.Text;

namespace Amfibia
{
    class Car :  ILandVehicle
    {
        Engine engine = new Engine();
        public void Drive()
        {
            if (this.engine.isEngineOn())
            {
                Console.WriteLine("Jadę po drodze");
            }
            
        }
    }
}
