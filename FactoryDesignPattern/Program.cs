
using FactoryDesignPattern;

public class Program
{

    //public static void Main(string[] args)
    //{
    //    string vechicleName = Console.ReadLine();

    //    VechicleFactory factory = new VechicleFactory();
    //    IVehicle vehicle = factory.CreateInstace(vechicleName);
    //    vehicle.Start();
    //    vehicle.Stop();
    //    Console.ReadKey();
    //}

}




//public static void Main(string[] args)
//{
//    string vechicleName = Console.ReadLine();
//    if (vechicleName.Equals("Car"))
//    {
//        IVehicleFactory factory = new CarFactory();
//        var car = factory.CreateVehicle();
//        car.Start();
//        car.Stop();
//    }

//}



//public class Program
//{
//    public static void Main(string[] args)
//    {
//        string vechicleName = Console.ReadLine();

//        IVehicle vehicle = GetVechicle(vechicleName);
//        vehicle.Start();
//        vehicle.Stop();
//        Console.ReadKey();

//    }

//    private static IVehicle GetVechicle(string vehicleName)
//    {
//        switch (vehicleName)
//        {
//            case "Car":
//                return new Car();
//            case "Truck":
//                return new Truck();
//            case "Bus":
//                return new Bus();
//            case "Tempo":
//                return new Tempo();
//            default:
//                throw new Exception("No such vechile found");

//        }

//    }




//}