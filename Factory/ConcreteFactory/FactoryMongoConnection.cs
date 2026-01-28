using DesignPattern.Factory.ConcreteProduct;
using DesignPattern.Factory.Interfaces;

namespace DesignPattern.Factory.ConcreteFactory
{
    public class FactoryMongoConnection : IFactoryConnection<IConnection>
    {
        public IConnection CreateItem() =>
            new ConnectionMongo();
    }
}
