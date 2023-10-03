using System;

namespace Exercicio8 {
    class Program {

        static double Pi = 3.14;

        static double Circunferencia(double raio) {
            return 2 * Pi * raio;
        }

        static void Main(string[] args) {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia (raio);

            Console.WriteLine($"Circunferência: {circ:F2}");
            
        }
    }
}