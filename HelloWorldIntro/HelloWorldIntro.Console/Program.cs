using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldIntro.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            System.Console.WriteLine("Hello World");

            int firstNumber;
            int secondNumber;
            int result;

            firstNumber = 5;
            secondNumber = 7;
            result = firstNumber + secondNumber;

            System.Console.WriteLine("the answer is " + result);
                

            //aislinn code here to tell how long it took
            var seconds = stopwatch.Elapsed.Milliseconds;
            System.Console.WriteLine(seconds + " milliseconds.");


            System.Console.ReadKey();
        }
    }
}
