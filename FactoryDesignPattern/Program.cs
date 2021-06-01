using System;

namespace FactoryDesignPattern
{
   
    interface IProduct
    {
        public string message();
    }

    class Factory
    {
        
        public IProduct FactoryMethod(int month)
        {
            if (month >= 1 && month <= 5)
            {
                return new ProductA();
            }
            else if (month >= 6 && month <= 11)
            {
                return new ProductB();

            }
            else
            {
                return null;
            }
        }
    }

    class ProductA : IProduct
    {
        public string message()
        {
            return "Avocado from Spain";
        }
    }

    class ProductB : IProduct
    {
        public string message()
        {
           return "Avocado from South Africa";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            try
            {
                for (int i = 1; i <= 12; i++)
                {
                    string product = factory.FactoryMethod(i).message();
                    Console.WriteLine(product);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No Avocado available in this month");
            }
           
        }
    }
}
