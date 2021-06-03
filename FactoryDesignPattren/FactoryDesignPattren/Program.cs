using System;

namespace FactoryDesignPattren
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            Console.WriteLine(c.factoryMethod().ship());
        }
    }

    interface IProduct
    {
        public string ship();
    }

    class ProdcutA : IProduct
    {
        public string ship()
        {
            return "span";
        }
    }
    class ProdcutB : IProduct
    {
        public string ship()
        {
            return "S.A";
        }
    }

    class Creator
    {
        public IProduct factoryMethod()
        {
            if (DateTime.Now.Month < 4)
            {
                return new ProdcutA();
            }if (DateTime.Now.Month == 12)
            {
                throw new Exception();
            }
            return new ProdcutB();

       }
    }
}
