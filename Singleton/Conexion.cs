namespace Singleton
{
    public class Conexion
    {
        private static Conexion _instance = null!;

        private Conexion()
        {
            
        }

        public static Conexion GetInstance()
        {
            if (_instance == null)
                _instance = new Conexion();
            return _instance;
        }

        public void Connect()
        {
            Console.WriteLine($"Conexión exitosa a la BD {_instance.GetHashCode()}");
        }

        public void Disconnect()
        {
            Console.WriteLine($"Desconexión exitosa a la BD {_instance.GetHashCode()}");
        }
    }
}
