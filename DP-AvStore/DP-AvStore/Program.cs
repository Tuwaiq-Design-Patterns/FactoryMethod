using System;

namespace DP_AvStore
{
    public interface ISupplyingAv
    {
        string Supply();
    }
    public class Spain : ISupplyingAv
    {
        public string Supply()
        {
            return "Spain";
        }
    }
    public class SouthAfrica : ISupplyingAv
    {
        public string Supply()
        {
            return "South Africa";
        }
    }
    public class Default : ISupplyingAv
    {
        public string Supply()
        {
            return "Default";
        }
    }
    public class Creator
    {
        public ISupplyingAv factoryMethod(int month)
        {
            if(month <= 4)
            {
                return new Spain();
            }
            else if((month > 4) || (month < 12))
            {
                return new SouthAfrica();
            }
            else if (month == 12)
            {
                return new Default();
            }
            else
            {
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            ISupplyingAv Av;

            for(int i = 1; i <= 12; i++)
            {
                Av = c.factoryMethod(i);
                Console.Write("Month {0} - ", i);
                Console.WriteLine(Av.Supply());
            }

        }
    }
}
