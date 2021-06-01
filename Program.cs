using System;

namespace Factory
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                creator c = new creator();
                IProduct product = c.factoryMethod((new DateTime()).Month);
                Console.WriteLine(product.order());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
    }

   public interface IProduct {
        public string order();
    }

  public  class spain : IProduct
    {
        public string order()
        {
            return "spain";
        }
    }

   public class SouthAfrica : IProduct
    {
        public string order()
        {
            return "SouthAfrica";
        }
    }

    

    public class creator
    {
        public IProduct factoryMethod(int month)
        {
            if (month>=1 && month<=4)
            {
                return new spain();
            }
            else if (month >= 7 && month <= 10)
            {
                return new SouthAfrica();
            }
            else
            {
                return null;
            }

            
        }
    }

}

