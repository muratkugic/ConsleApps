using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        public static List<Car> garage = new List<Car>();

        static void Main(string[] args)
        {
            GetCarInfo();

            string input = GetTextFromConsole("Press 'y/Y' to show the garage collection or 'n/N' to exit: ");
            
            if (input.ToLower() == "y")
            {
                Console.Clear();
                DisplayGarage(garage);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Program terminated, have a nice day!");
            }
        }

        

        static void GetCarInfo()
        {
            string addMoreCars = "";

            while (addMoreCars.ToLower() != "n")
            {
                Car dreamCar = new Car
                {
                    Manufacturer = GetTextFromConsole("Enter car manufacturer: "),
                    CarName = GetTextFromConsole("Enter car name/model name: "),
                    HorsePower = GetIntegerFromConsole("Enter horsepower: ")
                };

                addMoreCars = GetTextFromConsole("Press 'y/Y' to add another car else press 'n/N' to stop: ");

                garage.Add(dreamCar);
                Console.Clear();
            }
        }

        static void DisplayGarage(List<Car> garageList)
        {
            foreach (var car in garageList)
            {
                Console.WriteLine(car.CarInfo);
            }
        }

        static int GetIntegerFromConsole(string message)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();

            bool isValidNumber = int.TryParse(userInput, out int output);
            while (isValidNumber == false)
            {
                Console.WriteLine("Invalid format - please try again with whole numbers!");
                Console.WriteLine();

                Console.Write(message);
                userInput = Console.ReadLine();

                isValidNumber = int.TryParse(userInput, out output);
                Console.Clear();
            }

            return output;
        }

        static string GetTextFromConsole(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }
    }

    class Car
    {
        public string Manufacturer { get; set; }
        public string CarName { get; set; }
        public int HorsePower { get; set; }

        public string CarInfo
        {
            get
            {
                return $"Manufacturer:\t{ Manufacturer }\nName:\t\t{ CarName }\nHorsepower:\t{ HorsePower }\n";
            }
        }
    }
}
