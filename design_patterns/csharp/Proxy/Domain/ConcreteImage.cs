//ConcreteImage.cs - ConcreteSubject is the real object that the proxy represents.

using System;

namespace Proxy.Domain
{
    internal class ConcreteImage : IImage
    {
        string name;

        public ConcreteImage(string name)
        {
            this.name = name;
            LoadHighResolutionImage(name);
        }

        private void LoadHighResolutionImage(string name)
        {
            //Load image to memory. This is costly operation.
            Console.WriteLine("Loading image {0}.", name);
        }

        public void Display()
        {
            Console.WriteLine("Render Image {0}", name);
        }
    }
}