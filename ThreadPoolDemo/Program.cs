using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "MainThread";
            var employee = new Employee { Name = "jayesh", Mobile = "7990012540" };
            Console.WriteLine($"ThreadName : {Thread.CurrentThread.Name}. Is this ThreadPoolThreadc : {Thread.CurrentThread.IsThreadPoolThread}");
            ThreadPool.QueueUserWorkItem(new WaitCallback(PrintEmployeeDetail), employee);
            Console.WriteLine($"ThreadName : {Thread.CurrentThread.Name}. Is this ThreadPoolThreadc : {Thread.CurrentThread.IsThreadPoolThread}");
            Console.ReadKey();

            int maxWorkerThreads;
            int maxPortThreads;
            ThreadPool.GetMaxThreads(out maxWorkerThreads, out maxPortThreads);

            int minWorkerThreads;
            int minPortThreads;
            ThreadPool.GetMinThreads(out minWorkerThreads, out minPortThreads);

            Console.WriteLine($"maxWorkerThreads : {maxWorkerThreads}, maxPortThreads : {maxPortThreads}");
            Console.WriteLine($"minWorkerThreads : {minWorkerThreads}, minPortThreads : {minPortThreads}");
            Console.ReadKey();

            Console.Write($"ProcessorCount : {Environment.ProcessorCount}");
            Console.ReadKey();
        }

        private static void PrintEmployeeDetail(object employee)
        {

            var emp = employee as Employee;
            Console.WriteLine($"ThreadName : {Thread.CurrentThread.Name}. Is this ThreadPoolThreadc : {Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"Name : {emp.Name}, Mobile : {emp.Mobile}");
        }

        
    }

    internal class Employee
    {
        public string Name { get; internal set; }
        public string Mobile { get; internal set; }
    }
}
