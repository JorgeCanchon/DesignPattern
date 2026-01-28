using DesignPattern.Proxy.Imp;
using DesignPattern.Proxy.Interfaces;

namespace DesignPattern.Proxy
{
    public class Main
    {
        public void ExecuteExampleProxy()
        {
            Image image = new ProxyImage("tes_imp.jpg");

            //image will be loaded from disk
            image.Display();

            //imagen will not be loaded from disk
            image.Display();
        }
    }
}
