using System;

namespace factoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            IProduct product;
            product = c.factoryMethod(1);
            Console.WriteLine(product.Ship());
            product = c.factoryMethod(5);
            Console.WriteLine(product.Ship());
            product = c.factoryMethod(7);
            Console.WriteLine(product.Ship());
        }
    }
    public interface IProduct
    {
        string Ship();
    }
    class ProductSpain : IProduct
    {
        public string Ship()
        {
            return "Avocado From spain";
        }
    }
    class ProductSouthAfrica : IProduct
    {
        public string Ship()
        {
            return "Avocado From South Africa";
        }
    }
    class ProductNotSeacone : IProduct
    {
        public string Ship()
        {
            return "Not avocado seasone";
        }
    }
    public class Creator
    {
        public IProduct factoryMethod(int month)
        {
           
            if (month == 1 || month <= 4 )
            {
                return new ProductSpain();
            }
            else if (month > 4 && month <= 6)
            {
                return new ProductSouthAfrica();
            }
            else
            {
                return new ProductNotSeacone();
            }
        }
    }
}