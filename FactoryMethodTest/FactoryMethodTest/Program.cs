using System;

namespace FactoryMethodTest
{
    public interface IAvocado
    {
        string Delever();
    }

    public class SpainAvocado : IAvocado
    {
        public string Delever()
        {
            return "Spain Avocado";
        }
    }
    public class SouthAfricaAvocado : IAvocado
    {
        public string Delever()
        {
            return "South Africa Avocado";
        }
    }
    public class NoAvocado : IAvocado
    {
        public string Delever()
        {
            return "Sorry, There is no Avocado";
        }
    }

    public class Creator
    {
        public IAvocado FactoryMethod(int month )
        {
            if (month is > 0 and < 12)
            {
                return month < 5 ? new SpainAvocado() : new SouthAfricaAvocado();
            }
            return new NoAvocado();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAvocado avocado;
            Creator creator = new Creator();

            avocado = creator.FactoryMethod(2);
            Console.WriteLine(avocado.Delever());
            
            avocado = creator.FactoryMethod(6);
            Console.WriteLine(avocado.Delever());
            
            avocado = creator.FactoryMethod(12);
            Console.WriteLine(avocado.Delever());
        }
    }
}