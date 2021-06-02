namespace FactoryDesign
{
    public class AvocadoCreator
    {
        public IAvocado AvocadoProduct(int month)
        {
            if (month >= 1 && month <= 4)
            {
                return new SpainAvocado();
            }
            else if (month >= 5 && month <= 11)
            {
                return new SouthAfricaAvocado();
            }

            return null;
        }
    }
}