namespace FactoryMethodDemo
{
    public class AvocadoProvider
    {
        public IAvocado FactoryMethod(int month)
        {
            if (month > 0 && month < 6)
            {
                return new SpanishAvocado();
            }
            else if (month > 5 && month < 12)
            {
                return new SouthAfricanAvocado();
            }
            return new Default();
        }
    }
}