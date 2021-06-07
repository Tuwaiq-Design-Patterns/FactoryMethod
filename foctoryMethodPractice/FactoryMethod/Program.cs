using System;

namespace FactoryMethod
{
    //I => interface

    public interface IProduct
    {
        //method
        public string Delivered();

    }

    class Creator //in the example, it is the supplier
    {
        //private string message;


        public IProduct FactoryMethod(int month)
        {

            if (month == 1 || month == 2 || month == 3 || month == 4)
            {
                return new ProductA();
            }

            else if (month == 5 || month == 6 || month == 7 || month == 8 || month == 9 || month == 10 || month == 11)
            {
                return new ProductB();
            }
            else
            {
                return null;
            }


        }
    }
    /* We have two sources of Avocado from Spain and SA*/
    class ProductA : IProduct//concreate product
    {
        public string Delivered()
        {
            return "\n\tAvocados are shipped from Spain\n";
        }
    }

    class ProductB : IProduct
    {
        public string Delivered()
        {
            return "\n\tAvocados are shipped from South Africa\n";
        }

    }

/*===================================================*/

    class Program
    {
        
        static void Main(string[] args)//the main is the client who wants the Avocado to be available during the whole year regardless where it's coming from
        {
            int userChoice = 0;
            



            Console.WriteLine("\t Hi, Welcome to Arwa Avocados supply \n \t ");
            Console.WriteLine("\t Do you wish to order? (y/n)");
            string userWish = Console.ReadLine();

                

            while (userWish == "y")
            {
                Console.WriteLine("\n\tPlease, Enter which MONTH you want me to supply \n\tAnd I will tell you the source If you are Enterested...\n");

                userChoice = int.Parse(Console.ReadLine());

                if (userChoice >= 1 && userChoice <= 11)
                {
                    IProduct Avocado = new Creator().FactoryMethod(userChoice);
                    Console.WriteLine("\n\t ");
                    Console.Write(Avocado.Delivered());

                    Console.WriteLine("\n\t Do you wish to confirm your order for {0}? (y/n)", userChoice);
                    userWish = Console.ReadLine();

                    if(userWish == "y")
                    {
                        Console.WriteLine("\n\t Your Order is Confirmed......");
                    }
                    else
                    {
                        Console.WriteLine("\n\t Do you wish to order for Another month? (y/n)");
                        userWish = Console.ReadLine();

                    }



                }
                else if(userChoice ==12)
                {
                    Console.WriteLine("\n\tSorry, Avocados are not available in December :(...\n \n \tSorry for the inconvience");
                }
                else
                {
                    Console.WriteLine("\n\tSorry, Invalid Entry, Try again");
                    userWish = Console.ReadLine();
                }

                Console.WriteLine("\n\t Do you wish to order? (y/n)");
                userWish = Console.ReadLine();
            }

            Console.WriteLine("\n\t See you later ^-^)");
            Console.ReadLine();


        }
    }
}

