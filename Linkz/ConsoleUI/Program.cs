using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Entry[] entries = UrlEntries;

            DisplayMenu(entries);

            string userInput = GetUserInput("Enter your option: ");

            ValidateUserEntry(entries, userInput);
        }

        private static void ValidateUserEntry(Entry[] entries, string userInput)
        {
            bool foundEntry = false;

            foreach (var entry in entries)
            {
                if (userInput == entry.Key || userInput == entry.Name)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", entry.Url);
                        foundEntry = true;
                    }
                    catch
                    {
                        Console.WriteLine("You don't seem to have Firefox installed...");
                        Console.WriteLine("Please install the browser and try again.");
                    }
                }
            }

            if (foundEntry == false)
            {
                Console.WriteLine("\nCan't find a valid entry. Try again?");
                Console.WriteLine("\ty - Yes");
                Console.WriteLine("\tn - No");

                string userChoice = GetUserInput("\nOption: ");

                if (userChoice.ToLower() == "y" || userChoice.ToLower() == "yes")
                {
                    RestartApp();
                }
            }
        }

        private static string GetUserInput(string message)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();
            return userInput;
        }

        private static void DisplayMenu(Entry[] entries)
        {
            Console.WriteLine("Enter a letter and press Enter");
            Console.WriteLine();
            Console.WriteLine("Options:");

            foreach (var entry in entries)
            {
                Console.WriteLine($"\t{ entry.Key } - { entry.Name }");
            }

            Console.WriteLine();
        }

        private static Entry[] UrlEntries => new Entry[]
        {
            new Entry("www.twitter.com", "Twitter", "t"),
            new Entry("www.google.com", "Google", "g"),
            new Entry("www.youtube.com", "YouTube", "y"),
            new Entry("www.stackoverflow.com", "Stackoverflow", "s")
        };

        static void RestartApp()
        {
            Console.Clear();
            Main(null);
        }
    }
}
