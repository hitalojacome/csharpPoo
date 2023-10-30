using System;
using herencaPolimorfismo2.Entities;

namespace Workspace {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Product> list = new List<Product>(n);

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char cui = char.Parse(Console.ReadLine());

                if (cui == 'c' || cui == 'C') {
                    Console.Write("Name: ");
                    string? name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    Product product = new Product(name, price);
                    list.Add(product);
                } else if (cui == 'i' || cui == 'I') {
                    Console.Write("Name: ");
                    string? name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    Product importedProduct = new ImportedProduct(name, price, customsFee);
                    list.Add(importedProduct);
                } else if (cui == 'u' || cui == 'U') {
                    Console.Write("Name: ");
                    string? name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    Product usedProduct = new UsedProduct(name, price, manufactureDate);
                    list.Add(usedProduct);
                } else {
                    Console.WriteLine("Wrong answer!");
                }
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS: ");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(list[i]);
            }
        }
    }
}