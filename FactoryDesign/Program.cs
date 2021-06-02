using System;

namespace FactoryDesign
{
    public class Program
    {
        static void Main(string[] args)
        {
            Creator c = new();

            IProduct p = c.FactoryProduct(1);
            Console.WriteLine(p.Ship());


            AvocadoCreator ac = new();
            IAvocado a = ac.AvocadoProduct(DateTime.Now.Month);
            Console.WriteLine(a.Avocado());

            IAvocado b = ac.AvocadoProduct(1);
            Console.WriteLine(b.Avocado());
        }
    }
}