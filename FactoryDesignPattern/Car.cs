using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Car : IVehicle
    {
        public string VehicleName
        {
            get
            { 
                return "Car"; 
            }
        }

        public void Start()
        {
            Console.WriteLine(" I am a car and i am going to start");
        }

        public void Stop()
        {
            Console.WriteLine(" I am a car and i am going to stop");
        }
    }
}
