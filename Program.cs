using System;

namespace designpatren3
{
    interface IProduct
    {
        public void delever();
    }
    class AvocadoAspania : IProduct
    {
        public void delever()
        {
            Console.WriteLine("Avocado Spain");
        }
    }
    class AvocadoAsia : IProduct
    {
        public void delever()
        {
            Console.WriteLine("Avocado Asia");
        }
    }
    class Defult : IProduct
    {
        public void delever()
        {
           Console.WriteLine("Not Avocado");
        }
    
    }
    class Creator
    {
        public IProduct FActory(int Month)
        {
            switch (Month)
            {
                case 1: 
                case 2:
                case 3:
                case 4: return new AvocadoAspania(); 
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    return new AvocadoAsia();
                    break;
                default:
                    return new Defult();
                    break;
            }

         }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Creator Factory = new Creator();
            IProduct product = Factory.FActory(12);
            product.delever();
        }
    }
}
