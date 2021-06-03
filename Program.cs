using System;

namespace Factory
{
    public interface IProduct
    {
        public void Print();
    }
    
    public class ProductA : IProduct
    {
        public void Print()
        {
            Console.WriteLine("ProductA");
        }
    }
    
    public class ProductB : IProduct
    {
        public void Print()
        {
            Console.WriteLine("ProductB");
        }
    }

    public class ProductFactory
    {
        public static IProduct build(int month)
        {
            return month > 6 ? new ProductA() : new ProductB();
        }
    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            IProduct product1 = ProductFactory.build(3);
            IProduct product2 = ProductFactory.build(7);
            
            product1.Print();
            product2.Print();
        }
    }
}