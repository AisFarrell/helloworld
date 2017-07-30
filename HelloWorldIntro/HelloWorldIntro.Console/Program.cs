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

            //firstNumber = 5;
            //secondNumber = 7;
            //result = firstNumber + secondNumber;
            //System.Console.WriteLine("the answer is " + result.ToString());

            System.Console.WriteLine("Starting section 2");

            System.Console.Write("Pick first number;");
            string firstNumberString = System.Console.ReadLine();
            firstNumber = int.Parse(firstNumberString);


            System.Console.Write("Pick second number;");
            string secondNumberString = System.Console.ReadLine();
            secondNumber = int.Parse(secondNumberString);


            result = firstNumber * secondNumber;

            System.Console.WriteLine("the answer is " + result.ToString());


            System.Console.WriteLine("Ending section 2");



            //aislinn code here to tell how long it took
            var seconds = stopwatch.Elapsed.Milliseconds;
            System.Console.WriteLine(seconds + " milliseconds.");


            System.Console.ReadKey();
        }
    }
}
