using DesignPattern.AbstractFactory.Interfaces;
using DesignPattern.AbstractFactory.ConcreteFactory;

namespace DesignPattern.AbstractFactory
{
    public class Main
    {
        public void ExecuteExampleAbstractFactory()
        {
            Console.WriteLine("Creando Fabrica Abstracta");
            var modeDark = GetMode("Dark");
            var modeLight = GetMode("Light");

            modeDark.CreateButton().OnClick();
            modeLight.CreateButton().OnClick();

            modeDark.CreateList().DrownDown();
            modeLight.CreateList().DrownDown();
        }

        public IAbstractFactory GetMode(string mode) =>
            mode switch
            {
               "Dark" => new DarkMode(),
               "Light" => new LightMode(),
                _ => throw new ArgumentNullException(nameof(mode)),
            };
    }
}
