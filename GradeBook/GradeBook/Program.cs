using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new DiskBook("Feinmann's Grade Book");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named { book.Name }");
            Console.Clear();
            Console.WriteLine($"Lowest Grade: { stats.Low }");
            Console.WriteLine($"Highest Grade: { stats.High }");
            Console.WriteLine($"Grade average: {stats.Average }");
            Console.WriteLine($"The letter grade is { stats.Letter }");
            Console.WriteLine();
            Console.WriteLine(@"FILE LOCATION: C:\dev\ConsleApps\GradeBook\GradeBook\bin\Debug\netcoreapp3.0");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.Write("Enter a grade or 'q' to quit: ");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
