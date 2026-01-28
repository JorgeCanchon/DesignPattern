using DesignPattern.Factory.Interfaces;

namespace DesignPattern.Factory.ConcreteProduct
{
    public class ConnectionMongo : IConnection
    {
        private string _connectionString;

        public ConnectionMongo()
        {
            _connectionString = string.Empty;
        }

        public void Connect()
        {
            Console.WriteLine("Conectado a mongo");
        }

        public void Disconnect()
        {
            Console.WriteLine("Desconectado a mongo");
        }

        public void GetData()
        {
            Console.WriteLine("Data from Mongo");
        }
    }
}
