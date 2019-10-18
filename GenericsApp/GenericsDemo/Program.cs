using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = FizzBuzz("tests");
            Console.WriteLine($"Tests: { result }");

            result = FizzBuzz(123);
            Console.WriteLine($"123: { result }");

            result = FizzBuzz(true);
            Console.WriteLine($"True: { result }");

            result = FizzBuzz(new PersonModel { FirstName = "Murat", LastName = "Kugic" });
            Console.WriteLine($"PersonModel: { result }");

            result = FizzBuzz("testtesttesting");
            Console.WriteLine($"Testtesttesting: { result }");
        }

        private static string FizzBuzz<T>(T item)
        {
            int itemLength = item.ToString().Length;
            string output = "";

            if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }

            if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }

            return output;
        }
    }
}
