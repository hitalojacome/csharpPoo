using System;

namespace Exercicio7 {
    class Program {
        static void Main(string[] args) {
            
            Student aluno;
            aluno = new Student();

            Console.Write("Nome do aluno: ");
            aluno.Name = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.FirstGrade = double.Parse(Console.ReadLine());
            aluno.SecondGrade = double.Parse(Console.ReadLine());
            aluno.ThirdGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"NOTA FINAL = {aluno.FinalGrade():F2}");

            if (aluno.Approved()) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTAM {aluno.RemainingGrade():F2} PONTOS");
            }
        } 
    }
}