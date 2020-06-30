using System;
using System.Threading;
using System.Threading.Tasks;

namespace SyncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Step 1: You are in main thread");
            CallTimeConsumeTask();
            MyMethod();
            Console.WriteLine("Step 8: Main thread ended");
            Console.ReadLine();
        }

        static void CallTimeConsumeTask()
        {
            Console.WriteLine("Step 2: CallTimeConsumeTask() started");
            TimeConsumingTask();
            Console.WriteLine("Step 5: CallTimeConsumeTask() ended");
        }
        static void TimeConsumingTask()
        {
            Console.WriteLine("Step 3: TimeConsumingTask() started,waiting 5 seconds..");
            Thread.Sleep(5000);
            Console.WriteLine("Step 4: TimeConsumingTask() ended");
        }
        static void MyMethod()
        {
            Console.WriteLine("Step 6: Doing some work in MyMethod()");
            for (var i = 0; i <= 5; i++)
            {
                for (var j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Step 7: MyMethod() ended");
        }
    }
}