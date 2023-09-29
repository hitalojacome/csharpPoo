using System;

namespace workspace {
    class Program {             
        static void Main(string[] args) {

            Triangulo x, y; // Instânciando objetos (x e y) a classe Triangulo

            x = new Triangulo(); // Criando um novo objeto x
            y = new Triangulo(); // Criando um novo objeto y

            Console.Write("Entre com as medidas do triângulo X: ");
            string[] vet = Console.ReadLine().Split(' ');
            x.A = double.Parse(vet[0]); // Atribuindo um dado ao atributo A do objeto x
            x.B = double.Parse(vet[1]);
            x.C = double.Parse(vet[2]);

            Console.Write("Entre com as medidas do triângulo Y: ");
            vet = Console.ReadLine().Split(' ');
            y.A = double.Parse(vet[0]); // Atribuindo um dado ao atributo A do objeto y
            y.B = double.Parse(vet[1]);
            y.C = double.Parse(vet[2]);

            double p = (x.A + x.B + x.C) / 2.0;     
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;     
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"Área de X = {areaX:F4}");
            Console.WriteLine($"Área de Y = {areaY:F4}");

            if (areaX > areaY) {
                Console.WriteLine("Maior área = X");
            } else {
                Console.WriteLine("Maior área = Y");
            }
            
        }
    }
}