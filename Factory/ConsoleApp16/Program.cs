using System;

namespace FactoryConcept
{

    public interface IStore
    {
        string Ship();
    }
    public class UsSupplier : IStore
    {
        public string Ship() // the Supplier ship to store
        {
            return " US Supplier";
        }
    }
    public class SouthAfricaSupplier : IStore
    {
        public string Ship()
        {
            return "South Africa Supplier ";
        }
    }

    public class Creator 
    {
        public IStore FactoryMethod(int month)
        {
            if (month <= 6)
            {
                return new UsSupplier();
            }
            else if ((7 <= month) && (month <= 12))
            {
                return new SouthAfricaSupplier();
            }
            else if (month > 12)
            {
                Console.WriteLine("There is no season"); //the default value
            }

            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)  
        {
            Creator c = new Creator();
            IStore store;

            for (int i = 0; i <=13; i++)//13 Because of testing the default value
            {
                store = c.FactoryMethod(i);
                Console.WriteLine(store.Ship());

            }
           
        }
    }
}
