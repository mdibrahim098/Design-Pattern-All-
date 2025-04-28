using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AbstractFactory
    {
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            string description = Console.ReadLine();


        }

        private static IVehichleFactoryLoadFactory()
        {
            string factoryName = Properties.Settings.Default.DefaultVehiclefactory;

            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IVehichleFactoryLoadFactory;
        }

    }

    public interface IVehicle
    {
        string VehicleName
        {
            get;
        }
        void Start();
        void Stop();

    }


    public class Car : IVehicle
    {
        public string VehicleName
        {
            get { return "Car"; }
        }

        public void Start()
        {
            Console.WriteLine("Car started");
        }
        public void Stop()
        {
            Console.WriteLine("Car stopped");
        }
    }

    public class Truck : IVehicle
    {
        public string VehicleName
        {
            get { return "Truck"; }
        }
        public void Start()
        {
            Console.WriteLine("Truck started");
        }
        public void Stop()
        {
            Console.WriteLine("Truck stopped");
        }
    }


    public class Bus : IVehicle
    {
        public string VehicleName
        {
            get { return "Bus"; }
        }
        public void Start()
        {
            Console.WriteLine("Bus started");
        }
        public void Stop()
        {
            Console.WriteLine("Bus stopped");
        }

    }

    public class Tempo : IVehicle
    {
        public string VehicleName
        {
            get { return "Tempo"; }
        }
        public void Start()
        {
            Console.WriteLine("Tempo started");
        }
        public void Stop()
        {
            Console.WriteLine("Tempo stopped");
        }


    }

    public interface IVehichleFactory
    {
        IVehicle CreateVehicle(string description);

    }


        public class VehicleFactory :IVehichleFactory
        {
        Dictionary<string, Type> vehicles;
        public VehicleFactory()
        {
            LoadTypesCanReturn();
        }





        private void LoadTypesCanReturn()
        {
            vehicles = new Dictionary<string, Type>();
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in types)
            {
                if ( type.GetInterface(typeof(IVehicle).ToString()) != null)
                {
                    vehicles.Add(type.Name.ToLower(), type);
                }
            }


        }











    }
