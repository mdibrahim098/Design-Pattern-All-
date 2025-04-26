using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Thread_Safety_Singleton
    {


        public sealed class Singleton2
        {
            private Singleton2()
            {
                Console.WriteLine("This is thread safe singleton class");
            }
            private static readonly object Lock  = new object();

            private static Singleton2 instance = null;
            public static Singleton2 GetMethod
            {
                get
                {
                    lock(Lock)
                    {
                        if(instance == null)
                        {
                            instance = new Singleton2();
                        }
                        return instance;
                    }
                }
            }

        }

        //public static void  Main(string[] args)
        //{
        //    Singleton2 obj = Singleton2.GetMethod;

        //}




    }
}
