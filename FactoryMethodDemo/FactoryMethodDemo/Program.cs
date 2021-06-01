using System;

namespace FactoryMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AvocadoProvider provider = new AvocadoProvider();
            IAvocado client = provider.FactoryMethod(4);
            Console.WriteLine(client.Delivered());
        }
    }
}