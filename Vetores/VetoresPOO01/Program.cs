using System;

namespace VetPoo {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos produtos irá inserir? ");
            int n = int.Parse(Console.ReadLine());

            Product[] products = new Product[n]; // Criando vetor com classe
            
            for (int i=0; i<n; i++) {

                Console.Write($"Insira o nome do {i+1}° produto: ");
                string productName = Console.ReadLine();

                Console.Write($"Insira o valor do {i+1}° produto: ");
                double productPrice = double.Parse(Console.ReadLine());

                products[i] = new Product { Name = productName, Price = productPrice }; // Instanciando objetos

            }

            double sum = 0.0;
            for (int i=0; i<n; i++) {
                sum += products[i].Price; // Acessando o campo de preço em uma classe
            }


            double avg = sum / n;
            Console.WriteLine($"Média dos valores dos produtos R$ {avg:F2}");

        }
    }
}