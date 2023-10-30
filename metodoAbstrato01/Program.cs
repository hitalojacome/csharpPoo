using System;
using metodoAbstrato01.Entities;
using metodoAbstrato01.Entities.Enums;

namespace AbstractMethod {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Shape> list = new List<Shape>(n);

            for(int i = 1; i <= n; i++) {
            
                Console.WriteLine($"Shape #{i} data:");

                Console.Write("Retangle or Circle (r/c)? ");
                char retangleOrCircle = char.Parse(Console.ReadLine());

                if (retangleOrCircle == 'r' || retangleOrCircle == 'R') {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    Shape rectangle = new Rectangle(color, width, height);
                    list.Add(rectangle);
                } else if (retangleOrCircle == 'c' || retangleOrCircle == 'C') {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    Shape circle = new Circle(color, radius);
                    list.Add(circle);
                }
                Console.WriteLine();
            }

            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape shape in list) {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}