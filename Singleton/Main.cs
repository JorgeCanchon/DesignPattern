namespace Singleton
{
    /// <summary>
    /// El patron singleton es un patron de diseño creacional dada
    /// una clase de la que sola puede existir una instancia.
    /// </summary>
    public class Main
    {
        public void ExecuteExampleSingleton()
        {
            Console.WriteLine("Creando instancia #1");
            Conexion conexion = Conexion.GetInstance();

            Console.WriteLine("Creando instancia #2");
            Conexion conexion1 = Conexion.GetInstance();

            Console.WriteLine("Conectando desde instancia #1");
            conexion.Connect();

            Console.WriteLine("Desconectando desde instancia #2");
            conexion1.Disconnect();

            Console.WriteLine($"Instancias son iguales -> {conexion.Equals(conexion1)}");
        }
    }
}
