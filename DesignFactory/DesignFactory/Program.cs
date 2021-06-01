using System;

namespace DesignFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
                IProduct product;
           //product =  c.factoryMethod(1);
           // Console.WriteLine(product.Ship());
           // product = c.factoryMethod(2);
           // Console.WriteLine(product.Ship());
            for(int i = 1; i < 13; i++)
            {
                
                product = c.factoryMethod(i);
                if(product == null)
                {
                    Console.WriteLine("No Product.");
                }
                else
                {
                    Console.WriteLine(i + " " + product.Ship());
                }
                
            }

        }
    }

    public interface IProduct
    {
        string Ship();
    }
    class ProductA : IProduct
    {
        public string Ship()
        {
            return "Product came from Spain";
        }
    }
    public class ProductB : IProduct
    {
        public string Ship()
        {
            return "Product came from South Africa";
        }
    }
    public class Creator
    {
        public IProduct factoryMethod(int month)
        {
            // SP 1-4
            // S.A 5-11
            // default

            if (month >=1 && month <= 4)
            {
                return new ProductA();
            }
            else if(month >= 5 && month <= 11)
            {
                return new ProductB();
            }
            return null;
        }
    }
}
