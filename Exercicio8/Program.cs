using System;

namespace Exercicio8 {
    class Program {
        /* Está primeira forma estaremos resolvendo com membros estáticos
        static double Pi = 3.14; // Variável estática 

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
        // Agora resolveremos com uma classe instanciada
        static void Main(string[] args) {

            Calculadora calc = new Calculadora(); // Para chamar uma classe precisamos criar um objeto

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine($"Circunferência: {circ:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
            Console.WriteLine($"Valor de Pi: {calc.Pi:F2}");
            
        }*/

        static void Main(string[] args) {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
            Console.WriteLine($"Valor de Pi: {Calculadora.Pi:F2}");
            
        }
    }
}