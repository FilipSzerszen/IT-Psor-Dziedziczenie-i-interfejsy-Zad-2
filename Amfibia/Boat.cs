using System;
using System.Collections.Generic;
using System.Text;

namespace Amfibia
{
    class Boat : IWaterVehicle
    {
        public void Swim()
        {
            Console.WriteLine("Płynę po wodzie");
        }
    }
}
