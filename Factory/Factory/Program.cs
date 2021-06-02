using System;
namespace Factory
{
    class Program
    {
         static void  Main(string[]args)
        {
            // call the factory method from the Creator 
            var creator = new Creator();
            var _product = creator.FactoryMethod(11);
            Console.WriteLine(_product.Ship());
        }
        

    }
    

    public interface IProduct
    {
        string Ship(); 
    }
    public class Creator
    {
        // there must be only one method 
        // factory method will return a Iproduct
        // will create a product based on a condition 

        // sp 1-4 , S.A 5-11 , default 
        public IProduct FactoryMethod(int month )
        {

            if (month is >= 1 and <= 4)
            {
                return new ProductA(); 
            }else if (month is >=5 and <= 11)
            {
                return new ProductB(); 
            }

            throw new Exception(" We dont Have "); 
        }
        
    }
    public class ProductA:IProduct
    {
        public string Ship()
        {
            return "Spain" ; 
        } 
    }
    public class ProductB:IProduct
    {
        public string Ship()
        {
            return "South Africa"; 
        }
    }
    
    
    
}