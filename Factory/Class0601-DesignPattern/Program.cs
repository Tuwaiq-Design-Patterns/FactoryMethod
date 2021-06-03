using System;
namespace FactoryMethodTest
{
    public interface ITransportation
    {
        string Make();
    }
    public class Car : ITransportation
    {
        public String Make()
        {
            return "Car";
        }
    }
    public class Motorcycle : ITransportation
    {
        public string Make()
        {
            return "Bike";
        }
    }
    public class Bus : ITransportation
    {
        public string Make()
        {
            return "Bus";
        }
    }
    public class Creator
    {
        public ITransportation Manufactory(int month)
        {
            if (month is > 0 and < 12)
            {
                return month < 5 ? new Car() : new Motorcycle();
            }
            return new Bus();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ITransportation avocado;
            Creator creator = new Creator();
            avocado = creator.Manufactory(2);
            Console.WriteLine(avocado.Make());
            avocado = creator.Manufactory(6);
            Console.WriteLine(avocado.Make());
            avocado = creator.Manufactory(12);
            Console.WriteLine(avocado.Make());
        }
    }
}