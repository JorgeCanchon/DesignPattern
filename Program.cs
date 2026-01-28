namespace DesingPattern;

class Program
{
    static void Main(string[] args)
    {
        //Singleton();
        //Factory();
        //AbstractFactory();
        //StrategyFactory();
        //Prototype();
        Proxy();
    }

    /// <summary>
    /// los patrones de diseño creacional son patrones de diseño 
    /// que se ocupan de los mecanismos de creación de objetos, 
    /// tratando de crear objetos de una manera adecuada a la situación. 
    /// </summary>
    #region CreationalPatterns

    static void Singleton()
    {
        Title("Singleton");
        new Singleton.Main().ExecuteExampleSingleton();
    }

    static void Factory()
    {
        Title("Factory");
        new DesignPattern.Factory.Main().ExecuteExampleFactory();
    }

    static void AbstractFactory()
    {
        Title("Abstract Factory");
        new DesignPattern.AbstractFactory.Main().ExecuteExampleAbstractFactory();
    }

    static void Prototype()
    {
        Title("Prototype");
        new DesignPattern.Prototype.Main().ExecuteExamplePrototype();
    }
    #endregion


    #region BehaviorPattern

    static void StrategyFactory()
    {
        Title("Strategy");
        new DesignPattern.Strategy.Main().ExecuteExampleStrategy();
    }

    #endregion

    #region StructuralPattern

    static void Proxy()
    {
        Title("Proxy");
        new DesignPattern.Proxy.Main().ExecuteExampleProxy();
    }
    #endregion

    static void Title(string patternName)
    {
        Console.WriteLine($"Ejemplo patron creacional {patternName}");
    }
}
