using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContextSwitching
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Jayesh's Main Manager";
            Thread workerThread = new Thread(PrintThousandTimes);
            workerThread.Name = "Jayesh's Worker";
            //Worker Thread
            workerThread.Start();
            //Main Thread
            for (int i = 0; i < 1000; i++)
            {
                Console.Write($"MT{i} ");
            }
            Console.ReadKey();
        }

        private static void PrintThousandTimes()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write($"WT{i} ");
            }
        }
    }
}
