using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicle
    {
        public void StartEngine(string noisesToMakeWhenStarting)
        {
            Console.WriteLine($"Starting engine: {noisesToMakeWhenStarting}");
        }

        public void StopEngine(string noiseToMakeWhenStopping)
        {
            Console.WriteLine($"Stopping engine: {noiseToMakeWhenStopping}");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Default implemenatation of the Drive method.");
        }

    }
}
