using DesignPattern.Strategy.Imp;
using DesignPattern.Strategy.Interfaces;

namespace DesignPattern.Strategy
{
    /// <summary>
    /// El patron Strategy es un patron de diseño de comportamiento
    /// </summary>
    public class Main
    {
        public void ExecuteExampleStrategy()
        {
            var consoleLogger = new ConsoleLogger();
            var fileLogger = new FileLogger("C:\\Users\\Jorge Canchon\\Documents\\Estudio\\DesignPattern\\logger.txt");
            RunExampleStrategy(fileLogger);
            RunExampleStrategy(consoleLogger);
        }

        private void RunExampleStrategy(ILogger logger)
        {
            for (int i = 0; i < 10; i++) {
                logger.Write(new string('*', i));
            }
        }
    }
}
