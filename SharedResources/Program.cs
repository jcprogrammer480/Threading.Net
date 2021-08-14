using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharedResources
{
    class Program
    {
        private static bool isCompleted;
        //Let's use object to acuire lock
        private readonly static object lockCompleted = new object();

        static void Main(string[] args)
        {
            Thread worker = new Thread(HelloWorld);
            worker.Start();
            HelloWorld();

            Console.ReadKey();
        }

        private static void HelloWorld()
        {
            lock (lockCompleted)
            {
                if (!isCompleted)
                {
                    Console.WriteLine("Hello World");
                    isCompleted = true;
                }
            }
        }
    }
}
