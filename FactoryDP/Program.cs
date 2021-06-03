using System;

namespace FactoryDP
{
    
    public class Creator
    {
        public IProduct Factory_Method(int month)
        {
            // Spain 1-4, S.A 5-11 , default 12
            if(month>=1 && month<=4)
            {
                return new ProductA();

            }else if (month >= 5 && month <= 11)
            {
                return new ProductB();
            }
            throw new ArgumentException("no products found for month: "+ month);
        }
    }

    public interface IProduct
    {
        public string Ship();
    }
    class ProductA : IProduct
    {
        public string Ship()
        { return "From Spain"; }
    }
    class ProductB : IProduct
    {
        public string Ship()
        { return "From South Africa"; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IProduct product;
            Creator creator = new Creator();
            try
            {
                for(int i =1; i <= 12; i++)
                {
                    product = creator.Factory_Method(i);
                    Console.WriteLine(product.Ship());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
