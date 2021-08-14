using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolDemo
{
    class CheckJoin
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintHelloWorld);
            thread.IsBackground = true;
            thread.Start();
            Thread.Sleep(5000);
            thread.Join();
            Console.WriteLine("Hello world completed.");
            Console.ReadKey();
        }
        private static void PrintHelloWorld()
        {
            Console.WriteLine($"IsThreadPoolThread : {Thread.CurrentThread.IsThreadPoolThread}, IsBackGroud : {Thread.CurrentThread.IsBackground}");
            Console.WriteLine("Hello world.");
            Thread.Sleep(5000);
        }
    }
}
