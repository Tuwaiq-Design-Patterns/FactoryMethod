using System;
using System.Globalization;
namespace Factory
{
    public class Factory
    {
        public Factory() { }
        public IAvocado CreateAvocado(DateTime dateTime)
        {
            switch (dateTime.Month)
            {
                case <= 4:
                    return new SpanishAvocado();
                case <= 11:
                    return new SouthAfricanAvocado();
            }
            Console.WriteLine($"There are no Avocados in {new DateTimeFormatInfo().GetMonthName(dateTime.Month)}");
            return null;
        }
    }
}