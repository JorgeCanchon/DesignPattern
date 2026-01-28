using DesignPattern.AbstractFactory.ConcreteProduct;
using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.ConcreteFactory
{
    public class DarkMode : IAbstractFactory
    {
        public IButton CreateButton() =>
            new ButtonDarkMode();

        public IList CreateList() =>
            new ListDarkMode();
    }
}
