namespace FactoryMethodDemo
{
    public class Default : IAvocado
    {
        public string Delivered()
        {
            return "there is no Avocado this time of the year";
        }
    }
}