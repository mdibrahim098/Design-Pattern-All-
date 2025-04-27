using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ImplematationFactory
    {
    }


    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }
    }


    public class BusFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Bus();
        }
    }



    public class TruckFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }


    public class TempoFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Tempo();
        }
    }






}
