namespace FactoryDesign
{
    public class Creator
    {
        public IProduct FactoryProduct(int month)
        {
            if (month == 1)
            {
                return new ProductA();
            }
            else if (month == 2)
            {
                return new ProductB();
            }

            return null;
        }
    }
}