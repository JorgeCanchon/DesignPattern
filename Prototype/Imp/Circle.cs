using DesignPattern.Prototype.Interfaces;

namespace DesignPattern.Prototype.Imp
{
    public class Circle : IShape
    {
        private string _color;

        public Circle(string color)
        {
            _color = color;
        }

        public IShape Clone()
        {
            return new Circle(_color);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a {_color} circle");
        }
    }
}
