using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            Iproduct product;
            for (int i = 1; i < 13; i++)
            {
                product = c.factoryMethod(i);
                Console.WriteLine(product.Ship());
            }
            
           
        }
    }
    public interface Iproduct
    {
        string Ship();
    }
    public class SpainAvco : Iproduct
    {
        public string Ship()
        {
            return "Spain";
        }
    }
    public class SAAvco : Iproduct
    {
        public string Ship()
        {
            return "South Africa";
        }
    }

    public class NullAvco : Iproduct
    {
        public string Ship()
        {
            return "Nothing to share with you";
        }
    }
    public class Creator
    {
        public Iproduct factoryMethod(int month)
        {
            if (month >= 1 && month<=4)
            {
                return new SpainAvco();
            }
            else if (month>=5 && month<=11)
            {
                return new SAAvco();
            }

            return new NullAvco();
        }
        
    }
}