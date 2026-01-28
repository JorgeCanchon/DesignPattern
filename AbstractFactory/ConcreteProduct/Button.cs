using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.ConcreteProduct
{
    public class Button : Color, IButton 
    {
        public void OnClick()
        {
            Console.WriteLine($"Click al boton {ColorItem}");
        }
    }
}
