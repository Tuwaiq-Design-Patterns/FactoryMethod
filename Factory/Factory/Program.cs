using Factory;
using System;

namespace Factory
{
    public interface IAvocado
        {
            void avocado();
        }

    public class SpanishAvocado : IAvocado
        {
            public void avocado()
            {
                Console.WriteLine("Spanish Avocado");
            }
        }

    public class AfricanAvocado : IAvocado
        {
            public void avocado()
            {
                Console.WriteLine("African Avocado");
            }
        }
    public class NoAvocado : IAvocado
    {
        public void avocado()
        {
            Console.WriteLine("No Avocado");
        }
    }

    public class AvocadoFactory
    {
        public IAvocado Factory(int month)
        {
            if (month > 0 && month <= 6) { return new SpanishAvocado(); }
            else if (month > 6 && month <= 12) { return new AfricanAvocado(); }
            else { return new NoAvocado(); }
 
            }
        }
    }


class Program
{
    public static void Main(string[] args)
    {
        IAvocado avocado = null;
        AvocadoFactory avocadoFactory = new AvocadoFactory();
        avocado = avocadoFactory.Factory(13);
        print(avocado);

        avocado = avocadoFactory.Factory(6);
        print(avocado);

        avocado = avocadoFactory.Factory(8);
        print(avocado);
    }

    public static void print(IAvocado avacado)
    {
        avacado.avocado();
    }
}
