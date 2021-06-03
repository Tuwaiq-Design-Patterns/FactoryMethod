using System;

namespace Factory
{
    interface IAvocado
    {
        string Ship();
    }

    class SouthAfricaSupplier : IAvocado
    {
        public string Ship()
        {
            return "🥑 shipped from South Africa";
        }
    }

    class SpainSupplier : IAvocado
    {
        public string Ship()
        {
            return "🥑 shipped from Spain";
        }
    }

    class Creator
    {
        public IAvocado FactoryMethod(int month)
        {
            // 1-4 spain
            // 5-11 south africa
            // 12 null
            if (month >= 1 && month <= 4)
            {
                return new SpainSupplier();
            }
            
            if (month >= 5 && month <= 11)
            {
                return new SouthAfricaSupplier();
            }
            return null;
            
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            IAvocado avocado1 = c.FactoryMethod(5);
            Console.WriteLine(avocado1?.Ship());
            avocado1 = c.FactoryMethod(12);
            Console.WriteLine(avocado1?.Ship());
            
            IAvocado avocado2 = c.FactoryMethod(5);
            avocado2 = c.FactoryMethod(8);
            Console.WriteLine(avocado2?.Ship());
            avocado2 = c.FactoryMethod(2);
            Console.WriteLine(avocado2?.Ship());
        }
    }
}