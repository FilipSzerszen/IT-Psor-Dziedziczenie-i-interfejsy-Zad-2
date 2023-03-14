using System;
using System.Collections.Generic;
using System.Text;

namespace Amfibia
{
    class Motorboat : IWaterVehicle
    {
        Engine engine = new Engine();
        public void Swim()
        {
            Console.WriteLine("Płynę po wodzie");
        }
    }
}
