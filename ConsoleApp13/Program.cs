using System;

namespace ConsoleApp13
{
   
    
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            Iproduct product;
            product = c.factoryMethod(1);
            Console.WriteLine(product.Ship());
            product = c.factoryMethod(2);
            Console.WriteLine(product.Ship());
        }
    }
    public interface Iproduct
    {
        string Ship();
    }
    public class ProductA : Iproduct
    {
        public string Ship()
        {
            return "Product A";
        }
    }
    public class ProductB : Iproduct
    {
        public string Ship()
        {
            return "Product B";
        }
    }
    public class Creator
    {
        public Iproduct factoryMethod(int month)
        {
            if (month==1)
            {
                return new ProductA() ;
            }
            else if(month==2)
            {
                return new ProductB() ;
            }
            else
            {
                return null;
            }
        }
    }
}
