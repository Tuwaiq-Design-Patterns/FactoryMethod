using System;
using System.Collections.Generic;

namespace FactoryMethod
{

    public interface IAvocado
    {
        public string delivery();
        
    }

    public class SpanichAvocado : IAvocado
    {
        public string delivery() {

            return "Spanich Avocado Avaliable";
        }
        
    }

    public class SouthAfericaAvocado :IAvocado
    {
        public string delivery()
        {
           return "South Aferica Avocado Avaliable";
        }
    }

    public class AvocadoNotAvailable : IAvocado
    {
        public string delivery()
        {
            return "Avocado Not Avaliable";
        }
    }
     class Creator
    {
     public static IAvocado FactoryMethod(int month)
        {
            IAvocado fruit;

            if (0 < month && month < 4)
                fruit = new SpanichAvocado();

            else if (4 < month && month < 12)
                fruit = new SouthAfericaAvocado();

            else fruit = new AvocadoNotAvailable();

            return fruit;

        }
    }


    class Client
    {
        static void Main(string[] args)
        {
            IAvocado _Avocado;

            _Avocado = Creator.FactoryMethod(1);
            Console.WriteLine(_Avocado.delivery());

            _Avocado = Creator.FactoryMethod(5);
            Console.WriteLine(_Avocado.delivery());

            _Avocado = Creator.FactoryMethod(12);
            Console.WriteLine(_Avocado.delivery());
        }
    }
}
