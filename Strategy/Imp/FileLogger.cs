using DesignPattern.Strategy.Interfaces;

namespace DesignPattern.Strategy.Imp
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Write(string message)
        {
            File.AppendAllText(_filePath, message);
        }
    }
}
