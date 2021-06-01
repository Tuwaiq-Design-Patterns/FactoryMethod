using System;

namespace FactoryMethod
{
    class Program
    {
        public interface IProduct
        {
            string Operation();
        }

        class ProductA : IProduct
        {
            public string Operation()
            {
                return "Spain";
            }
        }

        class ProductB : IProduct
        {
            public string Operation()
            {
                return "South Africa";
            }
        }

        class ProductC : IProduct
        {
            public string Operation()
            {
                return "Saudi";
            }
        }

        class ProductDefault : IProduct
        {
            public string Operation()
            {
                return "Default";
            }
        }

        public class Creator 
        {
         public IProduct FactoryMethod(int month) 
            {
                if (month >= 1 && month <= 4)
                    return new ProductA();
                else if (month >= 5 && month <= 11)
                    return new ProductB();
                else if (month == 12) return new ProductC();
                else return new ProductDefault();
            }   
        }


        static void Main(string[] args)
        {
            Creator creator = new Creator();
            IProduct product1 = creator.FactoryMethod(1);
            Console.WriteLine("Product of month 1 comes from : "+product1.Operation());

            IProduct product2 = creator.FactoryMethod(5);
            Console.WriteLine("Product of month 5 comes from : " + product2.Operation());

            IProduct product3 = creator.FactoryMethod(12);
            Console.WriteLine("Product of month 12 comes from : " + product3.Operation());



        }
    }
}
