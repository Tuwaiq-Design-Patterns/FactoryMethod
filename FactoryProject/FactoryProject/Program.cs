using System;

namespace FactoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Creator().Factory(1)));
        }
    }
}
