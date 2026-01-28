namespace DesignPattern.AbstractFactory.ConcreteProduct
{
    public class Color
    {
        protected string ColorItem { get; private set; } = string.Empty;

        protected void SetColor(string color)
        {
            ColorItem = color;
        }
    }
}
