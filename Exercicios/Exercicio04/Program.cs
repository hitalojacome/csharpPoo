using System;

namespace Exercicio4 {
    class Program {             
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Instancição de um objeto passando os parametros do construtor
            Product x = new Product(name, price, quantity);

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