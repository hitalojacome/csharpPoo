using System;
using System.Diagnostics.CodeAnalysis;
using metodoAbstrato02.Entities;

namespace MetodoAbstrato02 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine()!);

            List<TaxPayer> list = new List<TaxPayer>();

            for(int i = 1; i <= n; i++) {

                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data:");
                
                Console.Write("Individual or company (i/c)? ");
                char individualOrCompany = char.Parse(Console.ReadLine()!);

                if(individualOrCompany == 'i' || individualOrCompany == 'I') 
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine()!;
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine()!);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine()!);

                    TaxPayer individual = new Individual(name, anualIncome, healthExpenditures);
                    list.Add(individual);

                } else if (individualOrCompany == 'c' || individualOrCompany == 'C') {
                    Console.Write("Name: ");
                    string name = Console.ReadLine()!;
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine()!);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine()!);

                    TaxPayer company = new Company(name, anualIncome, numberOfEmployees);
                    list.Add(company);

                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;
            for(int i = 0; i < n; i++) {
            
                Console.WriteLine(list[i]);
                sum += list[i].
            
            }

        }
    }
}