using DesignPattern.Strategy.Interfaces;

namespace DesignPattern.Strategy.Imp
{
    public class ConsoleLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
