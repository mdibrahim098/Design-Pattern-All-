using System;

namespace Singleton
{
    public sealed class Singleton3
    {
        private static readonly object Lock = new object();

       
        private static Singleton3 instance = null;

       
        private Singleton3() 
        {
            Console.WriteLine("Hello");
        }

        public static Singleton3 Instance
        {
            get
            {
               
                if (instance == null)
                {
                    lock (Lock)
                    {
                       
                        if (instance == null)
                        {
                            instance = new Singleton3();
                        }
                    }
                }

                return instance;
            }
        }
    }

    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    // Access the Singleton instance
        //    Singleton3 obj = Singleton3.Instance;
        //}
    }
}
