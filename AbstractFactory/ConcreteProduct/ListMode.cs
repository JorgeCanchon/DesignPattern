using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.ConcreteProduct
{
    public class ListMode : Color, IList
    {
        public void DrownDown()
        {
            Console.WriteLine($"DrownDown {ColorItem}");
        }
    }
}
