using System;

    namespace factoryDesignPattren
    {
        public class Program
        {
            static void Main(string[] args)
            {
                Creator c = new Creator();
                IProduct product;

                product = c.factoryMethod(1);
                Console.WriteLine(product.Ship());

                product = c.factoryMethod(5);
                Console.WriteLine(product.Ship());

                product = c.factoryMethod(12);
                Console.WriteLine(product.Ship());

        }
        }

        public interface IProduct
        {
            string Ship();
        }

        class ProductSpain : IProduct
        {
            public string Ship()
            {
                return "Avocado from spain";
            }
        }

        class ProductSA : IProduct
        {
            public string Ship()
            {
                return "Avocado from S.A";
            }

        }

        class ProductNoAvocado : IProduct
             {
        public string Ship()
        {
            return "There are no Avocado ";
        }
          }

    public class Creator
        {
            public IProduct factoryMethod(int month)
            {

                //spain 1-4
                //s.a 5-11
                //null

                if (month <= 4 && month > 0)
                {
                    return new ProductSpain();
                }
                else if (month >=5 && month <=11)
                {
                    return new ProductSA();

                }
                
                else
                return new ProductNoAvocado();


        }


        }



    }

