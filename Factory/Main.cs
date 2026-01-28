using DesignPattern.Factory.Interfaces;
using DesignPattern.Factory.ConcreteFactory;

namespace DesignPattern.Factory
{
    /// <summary>
    /// El patron Factory es un patron de diseño creacional
    /// Crea una instancia de varias clases derivadas
    /// creamos un objeto sin exponer la lógica de creación al cliente y nos referimos al objeto recién creado mediante una interfaz común.
    /// </summary>
    public class Main
    {
        public void ExecuteExampleFactory()
        {
            Console.WriteLine("Creando Fabrica");
            EnumConnection[] enums = [EnumConnection.ORACLE , EnumConnection.SQL, EnumConnection.MONGO];

            foreach (var item in enums.ToList())
            {
                IFactoryConnection<IConnection> cx1 = GetConnection(item);
                cx1.CreateItem().GetData();
            }
        }

        public static IFactoryConnection<IConnection> GetConnection(EnumConnection motor) =>
            motor switch
            {
                EnumConnection.SQL => new FactorySQLConnection(),
                EnumConnection.ORACLE => new FactoryOracleConnection(),
                EnumConnection.MONGO => new FactoryMongoConnection(),
                _ => throw new ArgumentNullException(nameof(motor)),
            };
    }
}
