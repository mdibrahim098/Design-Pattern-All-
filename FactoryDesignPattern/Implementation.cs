using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Implementation
    {
       
    }


    public class Car : IVehicle
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


    public class Truck : IVehicle
    {
        public string VehicleName
        {
            get
            {
                return "Truck";
            }
        }
        public void Start()
        {
            Console.WriteLine(" I am a truck and i am going to start");
        }
        public void Stop()
        {
            Console.WriteLine(" I am a truck and i am going to stop");
        }


    }

    public class Bus : IVehicle
    {
        public string VehicleName
        {
            get
            {
                return "Bus";
            }
        }
        public void Start()
        {
            Console.WriteLine(" I am a bus and i am going to start");
        }
        public void Stop()
        {
            Console.WriteLine(" I am a bus and i am going to stop");
        }

    }


    public class  Tempo : IVehicle
    {

        public string VehicleName
        {
            get
            {
                return "Bike";
            }
        }
        public void Start()
        {
            Console.WriteLine(" I am a Tempo and i am going to start");
        }
        public void Stop()
        {
            Console.WriteLine(" I am a Tempo and i am going to stop");
        }


    }







}
