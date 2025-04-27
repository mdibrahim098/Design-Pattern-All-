using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class FactoryClass
    {
    }




    public class VechicleFactory
    {
        Dictionary<string, Type> vehicles;
        public VechicleFactory()
        {
            LoadTyepsCanReturn();
        }

        public IVehicle CreateInstace(string vechicleName)
        {
            Type t = GetTypeToCreate(vechicleName);
            if (t == null)
            {
                throw new Exception("Bad Type");
            }
            else
            {
                return Activator.CreateInstance(t) as IVehicle;
            }

        }

        private Type GetTypeToCreate(string vechicleName)
        {
            foreach (var vehicle in vehicles)
            { 
                if (vehicle.Key.Equals(vechicleName.ToLower()))
                {
                    return vehicles[vehicle.Key];
                }
            }
            return null;

        }


        private void LoadTyepsCanReturn()
        {
            vehicles = new Dictionary<string, Type>();
            Type[] typeInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
       foreach(Type type in typeInThisAssembly)
            {
                if(type.GetInterface(typeof(IVehicle).Name) != null)
                {
                    vehicles.Add(type.Name.ToLower(), type);
                }
            }
        
        }

    }
}
