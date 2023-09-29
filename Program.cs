using System;

namespace workspace {
    class Program {             
        static void Main(string[] args) {

            Console.Write("Entre com as medidas do triângulo X: ");
            string[] vet = Console.ReadLine().Split(' ');
            double aX = double.Parse(vet[0]);
            double bX = double.Parse(vet[1]);
            double cX = double.Parse(vet[2]);

            Console.Write("Entre com as medidas do triângulo Y: ");
            vet = Console.ReadLine().Split(' ');
            double aY = double.Parse(vet[0]);
            double bY = double.Parse(vet[1]);
            double cY = double.Parse(vet[2]);

            double p = (aX + bX + cX) / 2.0;     
            double areaX = Math.Sqrt(p * (p - aX) * (p - bX) * (p - cX));

            p = (aY + bY + cY) / 2.0;     
            double areaY = Math.Sqrt(p * (p - aY) * (p - bY) * (p - cY));

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