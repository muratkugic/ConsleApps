using System;
using System.Collections.Generic;

namespace InterfacesAndInherintence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            BookModel book = CreateBook();
            PenModel pen = CreatePen();
            NotebookModel notebook = CreateNotebook();

            rentables.Add(book);
            purchasables.Add(book);
            purchasables.Add(pen);
            purchasables.Add(notebook);

            RunProgram(rentables, purchasables);
        }

        private static void RunProgram(List<IRentable> rentables, List<IPurchasable> purchasables)
        {
            Console.Write("Rent or Purchase something (r/p): ");
            string decision = Console.ReadLine();

            if (decision.ToLower() == "r")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Item: { item.ProductName }");
                    Console.Write("Rent this item (y/n): ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "y")
                    {
                        item.Rent();
                    }
                    Console.WriteLine();

                    Console.Write("Return item (y/n): ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "y")
                    {
                        Console.WriteLine($"Returned Item: { item.ProductName }");
                    }
                }
            }
            else
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Item: { item.ProductName }");
                    Console.Write("Purchase this product (y/n): ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "y")
                    {
                        item.Purchase();
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("Done!");
        }

        private static NotebookModel CreateNotebook()
        {
            return new NotebookModel
            {
                ProductName = "Notebook",
                Price = 35,
                QuantityInStock = 50
            };
        }

        private static PenModel CreatePen()
        {
            return new PenModel
            {
                ProductName = "Pen",
                Price = 250,
                QuantityInStock = 20
            };
        }

        private static BookModel CreateBook()
        {
            return new BookModel
            {
                ProductName = "Moby Dick",
                LateReturnFee = 5,
                QuantityInStock = 10
            };
        }
    }
}
