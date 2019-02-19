using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ibrahim Jesri";
            int age = 18;
            int futureAge = 0;
            
            if (age <= 18)
            { 
                futureAge = age + 7;
                Console.WriteLine($"In seven years, {name} will be {futureAge} years old.");
            }
            else
            {
                futureAge = age + 20;
                Console.WriteLine($"In 20 years, {name} will be {futureAge} years old.");
            }
            RefExample.SwapExample();
            OutExample.OutUsage();
            MyInformation.Ibrahim();
        }
    }

    class RefExample
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void SwapExample()
        {
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");    // Outputs "2 1"
        }
    }

    class OutExample
    {
        static void Divide(int x, int y, out int result, out int remainder)
        {
            result = x / y;
            remainder = x % y;
        }
        public static void OutUsage()
        {
            Divide(10, 3, out int res, out int rem);
            Console.WriteLine("{0} {1}", res, rem);	// Outputs "3 1"
        }
    }

    class MyInformation
    {
        public static void Ibrahim()
        {
            string firstName = "Ibrahim";
            string lastName = "Jesri";
            string city = "Wichita";
            string state = "Kansas";
            int age = 18;
            string fullName = firstName +  ' ' +lastName;

            Console.WriteLine($"{fullName} located in {city}, {state} is {age} years old!");
        }
    }
}
