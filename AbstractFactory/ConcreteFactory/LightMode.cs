using DesignPattern.AbstractFactory.ConcreteProduct;
using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.ConcreteFactory
{
    public class LightMode : IAbstractFactory
    {
        public IButton CreateButton() =>
            new ButtonLightMode();

        public IList CreateList() =>
            new ListLightMode();
    }
}
