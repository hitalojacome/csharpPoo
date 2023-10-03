using System;

namespace Exercicio8 {
    class Program {

        static double Pi = 3.14;

        static double Circunferencia(double raio) {
            return 2 * Pi * raio;
        }

        static double Volume(double raio) {
            return 4.0 / 3.0 * Pi * Math.Pow(raio,3);
        }

        static void Main(string[] args) {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine($"Circunferência: {circ:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
            Console.WriteLine($"Valor de Pi: {Pi:F2}");
            
        }
    }
}