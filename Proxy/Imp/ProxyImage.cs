using DesignPattern.Proxy.Interfaces;

namespace DesignPattern.Proxy.Imp
{
    public class ProxyImage(string fileName) : Image
    {
        private readonly string _fileName = fileName;
        private RealImage _realImage = null!;

        public void Display()
        {
            if(_realImage is null)
            {
                _realImage = new RealImage(_fileName); 
            }
            _realImage.Display();
        }
    }
}
