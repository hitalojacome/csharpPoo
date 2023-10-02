using System;

namespace Exercicio5 {
    class Program {
        static void Main(string[] args) {

            Retangle x;
            x = new Retangle();

            Console.Write("Entre com a largura e altura do retângulo: ");
            string[] values = Console.ReadLine().Split(' ');
            x.Width = double.Parse(values[0]);
            x.Height = double.Parse(values[1]);

            Console.WriteLine($"AREA = {x.Area():F2}");
            Console.WriteLine($"PERÍMETRO = {x.Perimeter():F2}");
            Console.WriteLine($"DIAGONAL = {x.Diagonal():F2}");
            
        }
    }
}