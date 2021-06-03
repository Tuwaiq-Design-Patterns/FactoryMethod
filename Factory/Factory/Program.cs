using System;
namespace Factory
{
    public interface IAvocado
    {
        string Delever();
    }
    public class SpainAvocado : IAvocado
    {
        public string Delever()
        {
            return "California";
        }
    }
    public class SouthAfricaAvocado : IAvocado
    {
        public string Delever()
        {
            return "Mexico";
        }
    }
    public class NoAvocado : IAvocado
    {
        public string Delever()
        {
            return "no Avocado";
        }
    }
    public class Creator
    {
        public IAvocado FactoryMethod(int month)
        {
            if (month > 0 && month < 12) return month < 5 ? new SpainAvocado() : new SouthAfricaAvocado();
            return new NoAvocado();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAvocado avocado;
            Creator creator = new Creator();
            avocado = creator.FactoryMethod(1);
            Console.WriteLine(avocado.Delever());
            avocado = creator.FactoryMethod(5);
            Console.WriteLine(avocado.Delever());
            avocado = creator.FactoryMethod(12);
            Console.WriteLine(avocado.Delever());
        }
    }
}