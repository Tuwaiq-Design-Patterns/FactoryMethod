using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // ShipCreator shipCreator = new ShipCreator();
            // Console.WriteLine(shipCreator.FactoryMethod(1).Ship());
            // Console.WriteLine(shipCreator.FactoryMethod(2).Ship());

            AvocadoCreator avocadoCreator = new AvocadoCreator();
            Console.WriteLine(avocadoCreator.FactoryMethod().Avocado());
        }
    }
    
    public interface IProduct
    {
        public string Ship();
    }

    public class ProductA : IProduct
    {
        public string Ship()
        {
            return "ProductA";
        }
    }
    public class ProductB : IProduct
    {
        public string Ship()
        {
            return "ProductB";
        }
    }

    public class ShipCreator
    {
        public IProduct FactoryMethod(int month)
        {
            if (month == 1) return new ProductA();
            if (month == 2) return new ProductB();
            
            return null;
        }
    }
    
    // --------------------------------- Avocado ------------------------------------------- //

    public interface IAvocado
    {
        public string Avocado();
    }
    
    public class ProductFromSpain : IAvocado
    {
        public string Avocado()
        {
            return "Spanish Avocado";
        }
    }
    public class ProductFromSouthAfrica : IAvocado
    {
        public string Avocado()
        {
            return "South African Avocado";
        }
    }
    
    public class AvocadoCreator
    {
        public IAvocado FactoryMethod()
        {
            int monthOfPurch = DateTime.Now.Month;
            
            if (monthOfPurch >= 1 && monthOfPurch < 6) return new ProductFromSpain();
            if (monthOfPurch >= 6 && monthOfPurch < 11) return new ProductFromSouthAfrica();

            return null;
        }
    }
}