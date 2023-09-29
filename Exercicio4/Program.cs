using System;

namespace Exercicio4 {
    class Program {             
        static void Main(string[] args) {

            Product x;
            x = new Product();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            x.name = Console.ReadLine();
            Console.Write("Preço: ");
            x.price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            x.quantity = int.Parse(Console.ReadLine());

            double total = x.TotalValueInStock();

            Console.WriteLine($"Dados do produto: {x.name}, $ {x.price:F2}, {x.quantity} unidades, Total: $ {total:F2}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int newProduct = int.Parse(Console.ReadLine());

            
            
        }
    }
}