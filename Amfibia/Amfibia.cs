using System;
using System.Collections.Generic;
using System.Text;

namespace Amfibia
{
    class Amfibia : IEngine, ILandVehicle, IWaterVehicle
    {
        Engine engine = new Engine();
        public void Drive()
        {
            Console.WriteLine("Jadę po drodze");
        }
        public void Swim()
        {
            Console.WriteLine("Pływam po wodzie");
        }
        public void startEngine()
        {
            engine.startEngine();
        }
        public void stopEngine()
        {
            engine.stopEngine();
        }
        public void isEngineOn()
        {
            return engine.isEngineOn();
        }
    }
}
