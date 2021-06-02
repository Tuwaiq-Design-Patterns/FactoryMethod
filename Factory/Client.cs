using System;

namespace Factory
{
    class Client
    {

        public interface IProduct
        {
            public string getType();
        }

        public class ProductA : IProduct
        {
            public string type;

            public ProductA(string type)
            {
                this.type = type;
            }

            public string getType()
            {
                return type;
            }
        }

        public class ProductB : IProduct
        {
            public string type;

            public ProductB(string type)
            {
                this.type = type;
            }

            public string getType()
            {
                return type;
            }
        }

        public class Creator
        {
            public IProduct createProduct(int month = 0)
            {
                if(month >= 1 && month <= 4)
                {
                    return new ProductA("Spanish Avocado");
                }

                if(month >= 5 && month <= 8)
                {
                    return new ProductB("South African Avocado");
                }

                return null;

            }
        }


        static void Main(string[] args)
        {
            IProduct product1;
            IProduct product2;
            IProduct product3;
            Creator c = new Creator();
            product1 = c.createProduct(2);
            product2 = c.createProduct(6);
            product3 = c.createProduct();
            Console.WriteLine(product1.getType());
            Console.WriteLine(product2.getType());
            if(product3 != null)
            {
                Console.WriteLine(product3.getType());
            } else
            {
                Console.WriteLine("No Avocado Available");
            }
            
        }
    }
}
