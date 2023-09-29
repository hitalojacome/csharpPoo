using System;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {

            Person p1, p2;

            p1 = new Person();
            p2 = new Person();

            Console.WriteLine("Insira os dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.name = Console.ReadLine();
            Console.Write("Idade: ");
            p1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.name = Console.ReadLine();
            Console.Write("Idade: ");
            p2.age = int.Parse(Console.ReadLine());

            if (p1.age > p2.age) {
                Console.WriteLine($"Pessoa mais velha: {p1.name}");
            } else {
                Console.WriteLine($"Pessoa mais velha: {p2.name}");
            }
            
        }
    }
}