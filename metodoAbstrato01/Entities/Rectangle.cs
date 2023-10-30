using metodoAbstrato01.Entities.Enums;

namespace metodoAbstrato01.Entities
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() {}
        public Rectangle(Color color, double width, double height) {
            Color = color;
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}