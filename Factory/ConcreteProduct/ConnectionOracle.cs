using DesignPattern.Factory.Interfaces;

namespace DesignPattern.Factory.ConcreteProduct
{
    public class ConnectionOracle : IConnection
    {
        private string _connectionString;
        public ConnectionOracle()
        {
            _connectionString = string.Empty;
        }

        public void Connect()
        {
            Console.WriteLine("Conectado a oracle");
        }

        public void Disconnect()
        {
            Console.WriteLine("Desconectado a oracle");
        }

        public void GetData()
        {
            Console.WriteLine("Data from Oracle");
        }
    }
}
