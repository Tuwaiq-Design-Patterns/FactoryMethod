using System;

namespace BerryFactory
{

    public interface IBerry
    {
        public string delivery();

    }

    public class TaifBerry : IBerry
    {
        public string delivery()
        {

            return "Taif berries are avaliable for purchase";
        }

    }

    public class AustralianBerry : IBerry
    {
        public string delivery()
        {
            return "Australian berries are avaliable for purchase";
        }
    }

    public class BerryNotAvailable : IBerry
    {
        public string delivery()
        {
            return "No berries are avaliable at this time of year...";
        }
    }
    class FruitStore
    {
        public static IBerry FactoryMethod(int month)
        {
            

            if (month is > 0 and < 6)
            {
                return month < 3 ? new TaifBerry() : new AustralianBerry();
            }
            return new BerryNotAvailable();

      
        }
    }


    class Customer
    {
        static void Main(string[] args)
        {
            IBerry _Berry;

            _Berry = FruitStore.FactoryMethod(1);
            Console.WriteLine(_Berry.delivery());

            _Berry = FruitStore.FactoryMethod(5);
            Console.WriteLine(_Berry.delivery());

            _Berry = FruitStore.FactoryMethod(8);
            Console.WriteLine(_Berry.delivery());
        }
    }
}
