using DesignPattern.Factory.ConcreteProduct;
using DesignPattern.Factory.Interfaces;

namespace DesignPattern.Factory.ConcreteFactory
{
    public class FactorySQLConnection : IFactoryConnection<IConnection>
    {
        public IConnection CreateItem() =>
            new ConnectionSQL();
    }
}
