using System;

namespace VetPoo2 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Tenant[] tenants = new Tenant[10];

            for (int i=1; i<=n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}");

                Console.Write("Nome: ");
                string tenantName = Console.ReadLine();
                Console.Write("Email: ");
                string tenantEmail = Console.ReadLine();
                Console.Write("Quarto: ");
                int tenantBedroom = int.Parse(Console.ReadLine());

                tenants[tenantBedroom] = new Tenant(tenantName, tenantEmail);
            }
            Console.WriteLine();
            
            Console.WriteLine("Quartos ocupados:");
            for (int i=0; i<9; i++) {
                if (tenants[i] != null ) {
                    Console.WriteLine($"{i}: {tenants[i]}");
                }
            } 
            
        }
    }
}