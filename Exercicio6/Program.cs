using System;

namespace Exercicio6 {
    class Program {
        static void Main(string[] args) {

            Employee x;
            x = new Employee();

            Console.Write("Nome: ");
            x.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            x.GrossSalary = double.Parse(Console.ReadLine());
            Console.Write("Impostos: ");
            x.Tax = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Funcionário: {x}");
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percentage = double.Parse(Console.ReadLine());
            x.IncreaseSalary(percentage);
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {x}");
        }
    }
}