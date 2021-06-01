using System;

namespace FactoryMethod
{

    public class Creator
    {
        public IAvocado getAvocado(int season)
        {

            if(season < 5)
            {
                return new SpanishAvocado();
            }
            else if (season < 11 && season > 5)
            {
                return new SouthAfricanAvocado();
            }
            else
            {
                return null;
            }
        }
    }


    /////////////////////////////////////////////
    public interface IAvocado
    {
        public string deliver();
    }

    public class SouthAfricanAvocado : IAvocado
    {
        public string deliver()
        {
            return "SOUTH AFRICAN AVOCADO";
        }
    }

    public class SpanishAvocado : IAvocado
    {
        public string deliver()
        {
            return "SPANISH AVOCADO";
        }
    }

    /////////////////////////////////////////////
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            Console.WriteLine(creator.getAvocado(7).deliver());
        }
    }
}
