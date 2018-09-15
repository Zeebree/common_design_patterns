// ProxyImage.cs - Proxy, have reference to ConcreteSubject and delegates calls to its method

namespace Proxy.Domain
{
    class ProxyImage : IImage
    {
        string name;
        ConcreteImage image;

        public ProxyImage(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            if(image == null)
            {
                //Create Image only when it is required to be shown
                image = new ConcreteImage(name);
            }

            // Call on concrete subject
            image.Display();
        }
    }
}
