using System;

namespace Avocado
{
    class Program
    {
        static void Main(string[] args)
        {
            AvocadoFactory avocadoFactory = new AvocadoFactory();
            ISupplyAvocado supplyAvocado = null;
            for (int i = 1; i <= 12; i++)
            {
                try
                {

                    supplyAvocado = avocadoFactory.GetSupply(i);
                    Console.WriteLine("At month " + i + " " + supplyAvocado.GetAvocado());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public interface ISupplyAvocado
        {
            string GetAvocado();

        }
        public class SpainSupplier : ISupplyAvocado
        {
            public string GetAvocado()
            {
                return ("Avocdao from Spain");
            }
        }

        public class SouthAfricaSupplier : ISupplyAvocado
        {
            public string GetAvocado()
            {
                return ("Avocdao from South Africa");
            }
        }

        public class AvocadoFactory
        {
            public AvocadoFactory()
            {

            }
            public ISupplyAvocado GetSupply(int month)
            {
                if (month >= 1 && month <= 4) return new SpainSupplier();
                else if (month >= 5 && month <= 10) return new SouthAfricaSupplier();
                throw new Exception("No Supplier at this time");
            }
        }

    }

   
}
