using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public  class NoThreadSafeSingleton
    {
    }

    ///No thread Safe Shingleton 
    ///


    public sealed class Singleton
    {
        private static Singleton instance = null;
        private Singleton()
        {
            Console.WriteLine("Singleton instance created.");
        }

        private static Singleton Method
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
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





}
