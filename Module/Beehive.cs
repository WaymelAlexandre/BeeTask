using System;
using System.Collections.Generic;
using System.Linq;
namespace Beestask
{
    public class Beehive
    {

        public int MaxAmountOfBee { get; set; }
        public int NumbreOfDay { get; set; }
        public float ToltalSide { get; set; }

        public List<Bee> ListBee = new List<Bee>();
        public Beehive(int numbeemax, List<Bee> listofbee)
        {
            this.MaxAmountOfBee = numbeemax;
            this.ListBee = listofbee;
        }
        public float AmountHoneyCollected(int Day, float totalside)
        {
            this.NumbreOfDay = Day;
            this.ToltalSide = totalside;

            return Day * totalside * 0.2f;
        }

        public void AddBee(Bee Newbee)
        {
            
            if (ListBee.Count != MaxAmountOfBee)
            {  
                ListBee.Add(Newbee);
            }
            else
            {
                System.Console.WriteLine($"no space for this bee the numbre max is {MaxAmountOfBee}  ");
            }
        }



    }
}
