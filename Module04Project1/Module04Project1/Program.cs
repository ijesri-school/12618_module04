using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            Console.WriteLine();

            var name = "Ibrahim Jesri";
            Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");
        }
    }
}