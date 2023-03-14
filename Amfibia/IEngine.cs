using System;
using System.Collections.Generic;
using System.Text;

namespace Amfibia
{
    interface IEngine
    {
        void startEngine();
        void stopEngine();
        bool isEngineOn();
    }
}
