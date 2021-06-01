using System;

namespace Factory
{
    class Client
    {
        static void Main(string[] args)
        {
            Factory factory = new();

            var avocado1 = factory.CreateAvocado(new DateTime(2021, 1, 1));
            if (avocado1 != null)
                Console.WriteLine($"This avocado is from {avocado1.Origin()}");

            var avocado2 = factory.CreateAvocado(new DateTime(2021, 5, 1));
            if (avocado2 != null)
                Console.WriteLine($"This avocado is from {avocado2.Origin()}");

            var avocado3 = factory.CreateAvocado(new DateTime(2021, 12, 1));
            if (avocado3 != null)
                Console.WriteLine($"This avocado is from {avocado3.Origin()}");

        }
    }
}
