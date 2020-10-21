using System;
using System.Threading;
namespace pr_08_01
{
    class Program
    {
        static void Counting()
        {
            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Count {i}, Thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(Counting);
            Thread first = new Thread(starter);
            Thread second = new Thread(starter);
            first. Start();
            second.Start();
            first.Join();
            second.Join();
            Console.Read();
        }
    }
}