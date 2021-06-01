using System;

namespace FactoryMethod
{
    public interface IAvocado
    {
        public string delivry();
    }
    public class Spain : IAvocado
    {
        public string delivry()
        {
            return "From spain";
        }
    }
    public class SA : IAvocado
    {
        public string delivry()
        {
            return "From South Africa";
        }
    }
    public class Supplier
    {
        public IAvocado getAvocado(int month)
        {
            if (month >= 1 && month <= 4)
                return new Spain();
            else if (month > 4 && month < 10)
                return new SA();
            else
                return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Supplier avocado = new Supplier();
            IAvocado product;
            for (int i = 1; i < 12; i++)
            {
                product = avocado.getAvocado(i);
                Console.WriteLine(product?.delivry());
            }
            
            
        }
    }
}
