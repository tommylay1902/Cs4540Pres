using System;
using System.Threading.Tasks;

namespace SimpleAsyncExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var calculate = CalculationAsync();
            Console.WriteLine("While CalculationsAsync is running, I can do other stuff here");
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("doing other stuff");
            }
            int result = await calculate;
            Console.WriteLine(result);

        }

        static async Task<int> CalculationAsync()
        {
            await Task.Delay(4000);
            Console.WriteLine("Completed Calculation");
            return 1;
        }
    }
}
