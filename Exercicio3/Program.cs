using System;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {

            Employee e1, e2;
            e1 = new Employee();
            e2 = new Employee();

            Console.WriteLine("Insira os dados do primeiro funcionário:");
            Console.Write("Nome: ");
            e1.name = Console.ReadLine();
            Console.Write("Salário: ");
            e1.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados do segundo funcionário:");
            Console.Write("Nome: ");
            e2.name = Console.ReadLine();
            Console.Write("Salário: ");
            e2.salary = double.Parse(Console.ReadLine());

            double avg = (e1.salary + e2.salary) / 2;

            Console.WriteLine($"Salário médio = R${avg:F2}");
            
        }
    }
}