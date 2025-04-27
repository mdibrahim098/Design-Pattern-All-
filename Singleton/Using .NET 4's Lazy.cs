using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class UsingLazy
    {
    }

    public  sealed class Singleton4
    {
        private Singleton4 () {}    

        private static readonly Lazy<Singleton4> lazy =
            new Lazy<Singleton4>(() => new Singleton4())

public static Singleton4 instance
        {
            get
            {
           return lazy.Value;
        }


  //         private static void Main(string[] args)
  //      {
		//	Singleton4 singleton = Singleton4.instance;
		//	Console.WriteLine("Singleton instance created.");

		//}


}
