namespace Exercicio5 {
    class Retangle {

        public double Width;
        public double Height;

        // Calculo da area do retangulo
        public double Area() {
            return Width * Height;
        }

        // Calculo do perimetro do retangulo
        public double Perimeter() {
            return 2 * (Width + Height); 
        }

        // Calculo da diagonal do retangulo
        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }
    }
}