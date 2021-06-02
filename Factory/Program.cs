using System;

namespace Factory
{


    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            Iproduct product;

            product = c.factoryMethod();
            Console.WriteLine(product.Ship());
            
        }
    }

    public interface Iproduct
    {
        string Ship();
    }
    public class ProductSpain : Iproduct
    {
        public string Ship()
        {
            return "Spain";
        }
    }

    public class ProductSouthAfrica : Iproduct
    {
        public string Ship()
        {
            return "South Africa";
        }
    }


    public class ProductNotFound : Iproduct
    {
        public string Ship()
        {
            return "Not Found";
        }
    }

    public class Creator
    {
        public Iproduct factoryMethod()
        {
            int monthOfPurch = DateTime.Now.Month ;
            if (monthOfPurch <= 4 && monthOfPurch >= 1)
            {
                return new ProductSpain();
            }
            else if (monthOfPurch <= 11 && monthOfPurch >= 5)
            {
                return new ProductSouthAfrica();
            }
            else
            {
                return new ProductNotFound();
            }
        }
    }

}
