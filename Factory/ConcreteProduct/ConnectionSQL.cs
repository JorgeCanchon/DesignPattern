using DesignPattern.Factory.Interfaces;

namespace DesignPattern.Factory.ConcreteProduct
{
    public class ConnectionSQL : IConnection
    {
        private string _connectionString;

        public ConnectionSQL()
        {
            _connectionString = string.Empty;
        }

        public void Connect()
        {
            Console.WriteLine("Conectado a SQL");
        }

        public void Disconnect()
        {
            Console.WriteLine("Desconectado a SQL");
        }

        public void GetData()
        {
            Console.WriteLine("Data from SQL");
        }
    }
}
