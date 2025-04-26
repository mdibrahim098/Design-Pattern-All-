



///No thread Safe Shingleton 
///


public sealed class Singleton1
{
    private static Singleton1 instance = null;
     private Singleton1() 
    { 
        Console.WriteLine("Singleton instance created.");
    }

    private static Singleton1 Method
    {
        get
        {
            if(instance == null)
            {
                instance = new Singleton1();
            }
            return instance;
        }
    }

    //public static void Main(string[] args)
    //{
    //    Singleton singleton = Singleton.Method;
    //    Singleton singleton1 = Singleton.Method;
    //    Console.WriteLine(singleton);
    //    Console.WriteLine(singleton1);
    //}
}


