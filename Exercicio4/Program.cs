using System;

namespace Exercicio4 {
    class Program {             
        static void Main(string[] args) {

            Product x;
            x = new Product();

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome: ");
            x.Name = Console.ReadLine();
            Console.Write("Preço: ");
            x.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            x.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Dados do produto: {x}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtt = int.Parse(Console.ReadLine());
            x.AddProduct(qtt);
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {x}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtt = int.Parse(Console.ReadLine());
            x.RemoveProduct(qtt);
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {x}");
            
        }
    }
}