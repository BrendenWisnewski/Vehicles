using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane");
            Airplane myFlight = new Airplane();
            myFlight.StartEngine("Contact");
            myFlight.TakeOff();
            myFlight.Drive();
            myFlight.Land();
            myFlight.StopEngine("whirr");

            Console.WriteLine();
            Console.WriteLine("Journey by car");
            Car myVW = new Car();
            myVW.StartEngine("Loud Deisel Rumble");
            myVW.Accelerate();
            myVW.Drive();
            myVW.Brake();
            myVW.StopEngine("sad rumble");

            Console.WriteLine("\nTesting polymorphism...");
            Vehicle v = myVW;
            v.Drive();
            v = myFlight;
            v.Drive();
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
