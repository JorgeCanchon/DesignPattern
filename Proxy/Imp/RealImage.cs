using DesignPattern.Proxy.Interfaces;

namespace DesignPattern.Proxy.Imp
{
    public class RealImage : Image
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk();
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {_fileName}");
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading {_fileName}");
        }
    }
}
