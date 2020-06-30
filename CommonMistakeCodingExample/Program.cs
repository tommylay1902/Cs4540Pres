using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace CommonMistakeCodingExample
{
    class MidtermExample
    {

        static async Task Main(string[] args)
        {
            var result = Num1();
            Console.WriteLine(result);
            var result2 = await Num1();
            Console.WriteLine(result2);
            /*await Num2();*/

            Console.WriteLine("Fun with Async ===>");
            DisplayCurrentInfo();
        }
        public static async Task<int> Num1()
        {
            int sum = 0;
            await Task.Delay(2000);
            for (int i = 0; i < 10000; i++)
                sum += i;
            return 1;
        }
        public static async void DisplayCurrentInfo()
        {
            Console.WriteLine($"Today is {DateTime.Now:D}");
            Console.WriteLine($"Today is {DateTime.Now.TimeOfDay:t}");
            Console.WriteLine($"The current temperture is 76 degree.");
            await Task.Delay(2000);
            Console.WriteLine("Back to main!");
        }
/*        public static Task<int> Num2()
        {
            return 2;
        }
*/
    }
}