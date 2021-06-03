using System;

namespace FactoryApp
{
    public interface IProduct
    {
        string Ship();
    }
    public class ProductA: IProduct
    {
        public string Ship()
        {
            return "From ProductA";
        }
    }
    public class ProductB : IProduct
    {
        public string Ship()
        {
            return "From ProductB";
        }
    }
    public class Creator
    {
        public IProduct Create(int month)
        {
            if(month > 5)
            {
                return new ProductA();
            } else
            {
                return new ProductB();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();

            IProduct p = c.Create(2);
            IProduct p2 = c.Create(6);

            Console.WriteLine(p.Ship());
            Console.WriteLine(p2.Ship());

        }
    }
}
