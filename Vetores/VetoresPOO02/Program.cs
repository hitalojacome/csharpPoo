using System;

namespace VetPoo2 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Tenant[] tenants = new Tenant[9];

            for (int i=0; i<n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i+1}");

                Console.Write("Nome: ");
                string tenantName = Console.ReadLine();
                Console.Write("Email: ");
                string tenantEmail = Console.ReadLine();
                Console.Write("Quarto: ");
                int tenantBedroom = int.Parse(Console.ReadLine());

                tenants[tenantBedroom-1] = new Tenant { Name = tenantName, Email = tenantEmail, Bedroom = tenantBedroom };
            }
            Console.WriteLine();
            
            Console.WriteLine("Quartos ocupados:");
            for (int i=0; i<9; i++) {
                if (tenants[i] != null ) {
                    Console.WriteLine($"{tenants[i].Bedroom}: {tenants[i].Name}, {tenants[i].Email}");
                }
            } 
            
        }
    }
}