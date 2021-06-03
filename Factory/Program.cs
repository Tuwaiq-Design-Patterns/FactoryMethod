using System;

namespace Factory
{
    public interface IProduct
    {
        public string Delivary();
    }

    class FactoryCreator 
    {
        private string srt;

        public IProduct FactoryMethod(int month)
        {
         
            if (month == 1)
                return new ProductA();
            else if (month == 2)
                return new ProductB();
            return null;
        }
    }

    class ProductA : IProduct
    {
        public string Delivary()
        {
            return "Delivary A";
        }
    }

    class ProductB : IProduct
    {
        public string Delivary()
        {
            return "Delivary B";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IProduct p1 = new FactoryCreator().FactoryMethod(1);
            IProduct p2 = new FactoryCreator().FactoryMethod(2);
            IProduct p3 = new FactoryCreator().FactoryMethod(3);
            if(p3==null)
                Console.WriteLine("No Month");
            Console.WriteLine(p1.Delivary());
            Console.WriteLine(p2.Delivary());
        }
    }
}
