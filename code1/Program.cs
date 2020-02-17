using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code1
{
    class Program
    {

        static void Main(string[] args)
        {
            var item = (name: "eggs", price: 1.99m, perPackage: 3);

            var date = DateTime.Now;

            Console.WriteLine($"time of purchase:" +
                                $"{date:t}\nproduct name: {item.name}\n" +
                                $"item price:{item.price:C3}\n" +
                                $"per {item.perPackage} items. ");
            Console.WriteLine($"|{"Item",-25}|{"Quantity",-25}|");

            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");

            Console.ReadKey();
        }
        public static int adder(int a, int b)
        {
            int c = a + b;

            return c;
        }
    }
}
/*formating time use :d
 * formating currency use C2 means currentcy 
 * 
 * Try modifying the format strings in the example to see how they affect 
 * the formatting of the date and time and the numeric value. Change the "d"
 * in {date:d} to "t" (to display the short time format), "y" 
 * (to display the year and month), * and "yyyy" (to display the year as a four-digit number). 
 * Change the "C2" in {price:C2} to "e" (for exponential notation) and "F3" 
 * (for a numeric value with three digits after the decimal point).
 * 
 * Console.WriteLine("please enter two intergers: ");
            Console.Write("Number 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}",a,b,adder(a,b));
              string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");  var names = new List<string> { "kick","Alex", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();

            names.Add("alia");
            names.Insert(1, "anastasia");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            var fibonacciNumbers = new List<int> { 1, 1 };

            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);


            while (fibonacciNumbers.Count < 20)
            {
                 previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                 previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

*/
