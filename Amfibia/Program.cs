using System;

namespace Amfibia
{
    class Program
    {
        static void Main(string[] args)
        {
            var Motorboat = new Motorboat();
            Motorboat.Swim();

            var Car = new Car();
            Car.Drive();

            var Amfibia = new Amfibia();
            Amfibia.startEngine();
            Amfibia.Drive();
            Amfibia.Swim();
            Amfibia.stopEngine();
        }
    }
}
