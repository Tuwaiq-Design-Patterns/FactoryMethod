using System;

namespace Factory_design_pattern
{
    public interface IProduct
    {
        string Ship();
    }
    public class Spain : IProduct
    {
        public string Ship()
        {
            return "Avocado from Spain";
        }
    }
    public class SAfrica : IProduct
    {
        public string Ship()
        {
            return "Avocado from S.A.";
        }
    }
    public class Creator
    {
        public IProduct FactoryMethod(int month)
        {
            if(month >= 1 && month<=4)
            {
                return new Spain();
            } else if (month >= 5 && month <= 11)
            {
                return new SAfrica();
            } else
            {
                Console.WriteLine("no avocados");
                return null;
            }
            //spain 1~4
            //S.africa 5~11
            //(12) default null
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Client
            Creator c = new Creator();
            IProduct product;
            product = c.FactoryMethod(12);
            Console.WriteLine(product?.Ship());
        }
    }
}
