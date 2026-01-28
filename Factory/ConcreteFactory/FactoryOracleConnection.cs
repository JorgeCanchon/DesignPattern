using DesignPattern.Factory.ConcreteProduct;
using DesignPattern.Factory.Interfaces;

namespace DesignPattern.Factory.ConcreteFactory
{
    public class FactoryOracleConnection : IFactoryConnection<IConnection>
    {
        public IConnection CreateItem() =>
          new ConnectionOracle();
    }
}
