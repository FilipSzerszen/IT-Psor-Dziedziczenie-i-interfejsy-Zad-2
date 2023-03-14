using System;
using System.Collections.Generic;
using System.Text;

namespace Amfibia
{
    class Engine
    {
        private bool EngineOn = false;

        public void startEngine()
        {
            if (!EngineOn)
            {
                Console.WriteLine("Silnik włączony");
                EngineOn = true;
            }
            else
            {
                Console.WriteLine("Silnik jest już włączony");
            }
        }
        public void stopEngine()
        {
            if (EngineOn)
            {
                Console.WriteLine("Silnik wyłączony");
                EngineOn = false;
            }
            else
            {
                Console.WriteLine("Silnik jest już wyłączony");
            }
        }

        public bool isEngineOn()
        {
            return EngineOn;
        }
    }
}
