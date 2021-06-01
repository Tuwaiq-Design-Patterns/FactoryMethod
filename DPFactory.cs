using System;

namespace DPavocado
{
    public interface SupplyerAvocado
    {
        string avocadosSeller();

    }

    class AvocadoSpain : SupplyerAvocado
    {

        public string avocadosSeller()
        {

            return "Avocado Spain";
        }

    }


    class AvocadoAfrica : SupplyerAvocado
    {
        public string avocadosSeller()
        {

            return "Avocado africa";
        }

    }
    public class Creator
    {
        public SupplyerAvocado FactoryMethod(int month)
        {
            if ((month == 1) || (month == 2) || (month == 3) || (month == 4) || (month == 5))// 1-5 spain
            {
                return new AvocadoSpain();
            }
            else if ((month == 6) || (month == 7) || (month == 8) || (month == 9) || (month == 10))
            {
                return new AvocadoAfrica(); //5-10 sauthafrica

            }
            else
            {
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Creator c = new Creator();
                SupplyerAvocado avocado;
                avocado = c.FactoryMethod(i);

                Console.WriteLine(avocado.avocadosSeller());
            }
            //avocado = c.FactoryMethod(10);
            //Console.WriteLine(avocado.avocadosSeller());

        }
    }
}
        
    

   

