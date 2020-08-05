using System;
using System.Collections.Generic;
using System.Linq;

namespace Beestask
{
    class Program
    {
        static void Main(string[] args)
        {
            int DayChoose;  // num of day befor collect
            List<Bee> ListBeeHive2 = new List<Bee>();
            List<Bee> ListBeeHive1 = new List<Bee>();
            Beehive BeeHome1 = new Beehive(20, ListBeeHive1);
            Beehive BeeHome2 = new Beehive(20, ListBeeHive2);

            BeeHome1.AddBee(new Bee("John", 3.2f));
            BeeHome1.AddBee(new Bee("Paul", 2.7f));
            BeeHome1.AddBee(new Bee("George", 1.1f));
            BeeHome1.AddBee(new Bee("Ringo", 2.0f));
            
            //Bee List 2 /Beehive2
            BeeHome2.AddBee(new Bee("Kurt", 2.3f));
            BeeHome2.AddBee(new Bee("Dave", 7.4f));
            BeeHome2.AddBee(new Bee("Krist", 1.5f));

            System.Console.WriteLine("Choose along you want a wait for collection all you honey in your beeframe ");
            DayChoose = int.Parse(System.Console.ReadLine());

            float sumBeehive1 = 0;      // total side bees in beehive1
            float sumBeehive2 = 0;      // total side bees in beehive2
            for (int i = 0; i < ListBeeHive1.Count; i++) //Loop for know all the totalSide of all Bees
            {
                sumBeehive1 = ListBeeHive1[i].BeeSize + sumBeehive1;     //add each beeside Beehive1
            }
            for (int i = 0; i < ListBeeHive2.Count; i++)    //Loop for know all the totalSide of all Bees
            {
                sumBeehive2 = ListBeeHive2[i].BeeSize + sumBeehive2;    //add each beeside Beehive2
            }

            float totalOfHoneyBeehive1 = BeeHome1.AmountHoneyCollected(DayChoose, sumBeehive1);     //day * totalsyde * 2  in beehive1
            float totalOfHoneyBeehive2 = BeeHome2.AmountHoneyCollected(DayChoose, sumBeehive2);     //day * totalsyde * 2  in beehive2


            System.Console.WriteLine($" Total collected on beehive1 '{totalOfHoneyBeehive1} Grams' \n with '{ListBeeHive1.Count}' Bees on it \n Total collect on beehive2 '{totalOfHoneyBeehive2} Grames' \n with '{ListBeeHive2.Count}' Bees on it");

        }
    }
}
