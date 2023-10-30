using metodoAbstrato01.Entities.Enums;

namespace metodoAbstrato01.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color) {
            Color = color;
        }

        public abstract double Area();
    }
}