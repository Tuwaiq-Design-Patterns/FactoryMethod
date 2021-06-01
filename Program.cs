using System;
namespace DesignPattern_factoryMethod
{


    //###################################################################
    //############# Creator class and its FactoryMethod #################
    //###################################################################
    class Creator
    {
        static public IAvocado FactoryMethod(int month)
        {
            IAvocado product;
            if ( 0< month && month < 5)  product = new SpanishAvocado();

            else if ( 5< month && month < 12) product = new SouthAfricanAvocado();

            else product = new UnavailableAvocado();

            return product;

        }
    }

    //###################################################################
    //######### IAvocado interface and its implemented classes ##########
    //###################################################################
    internal interface IAvocado
    {
        public string deliveryMsg();
    }

    class SpanishAvocado : IAvocado
    {
        public string deliveryMsg()
        {
            return "This product was delivered from Spain";
        }
    }
    class SouthAfricanAvocado : IAvocado
    {
        public string deliveryMsg()
        {
            return "This product was delivered from South Africa";
        }
    }

    class UnavailableAvocado : IAvocado
    {
        public string deliveryMsg()
        {
            return "Sorry, This product is not available for the month of production you asked for!";
        }
    }




    //######################################
    //############# Client #################
    //######################################
    class Program
    {
        static void Main(string[] args)
        {
            IAvocado product;

            product = Creator.FactoryMethod(month: 3);
            Console.WriteLine(product.deliveryMsg());


            product = Creator.FactoryMethod(7);
            Console.WriteLine(product.deliveryMsg());

            product = Creator.FactoryMethod(12);
            Console.WriteLine(product.deliveryMsg());
        }
    }
}

// Outputs:
// -- This product was delivered from Spain
// -- This product was delivered from South Africa
// -- Sorry, This product is not available for the month of production you asked for!

