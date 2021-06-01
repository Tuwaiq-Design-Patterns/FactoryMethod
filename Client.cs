using System;

namespace ConsoleApp3
{

    internal interface IAvocado
    {
        public string Massege();
    }

    class Creator
        {
            static public IAvocado FactoryMethod(int month)
            {
                IAvocado product;
                if (0 < month && month < 5) 
                product = new Spanish();

                else if (5 < month && month < 12)
                product = new SouthAfrica();

                else product = new Notavailable();

                return product;

            }
        }

      
     
        class Spanish : IAvocado
        {
            public string Massege()
            {
                return " The prodect from Spain";
            }
        }
        class SouthAfrica : IAvocado
        {
            public string Massege()
            {
                return "The _Avocado from South Africa";
            }
        }

        class Notavailable : IAvocado
        {
            public string Massege()
            {
                return "Not available right now ";
            }
        }
        class Client
        {
            static void Main(string[] args)
            {
                IAvocado _Avocado;

             _Avocado = Creator.FactoryMethod(2);
            Console.WriteLine(_Avocado.Massege());

            _Avocado = Creator.FactoryMethod(6);
            Console.WriteLine(_Avocado.Massege());

            _Avocado = Creator.FactoryMethod(12);
            Console.WriteLine(_Avocado.Massege());
            }
        }
    }

