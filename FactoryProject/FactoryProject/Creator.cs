using System;
namespace FactoryProject
{
    public class Creator
    {
        

        public String Factory(int month)
        {
            if (month>0 && month <= 4)
                return new AvogadroA().Name;
            else if(month>=5 && month<=11)
                return new AvogadroB().Name;
            return "not avalibe right now";

        }

    }

   public interface IAvogadro
    {
        public String getName();
    }

   public class AvogadroA : IAvogadro
    {
        
        public String Name = "Avogadro From spain";

        public String getName()
        {
            return this.Name;
        }
    }


    public class AvogadroB : IAvogadro
    {

        public String Name= "Avogadro From S.A.";

        public AvogadroB()
        {
            this.getName();
        }

        public String getName()
        {
            return this.Name;
        }
    }
}