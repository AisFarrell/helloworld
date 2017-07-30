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

            //aislinn code here to tell how long it took
            
            System.Console.ReadKey();
        }
    }
}
