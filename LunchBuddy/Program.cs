using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {


            LunchBuddy lunchBuddy1 = new LunchBuddy("John", "Key");

            LunchBuddy lunchBuddy2 = new LunchBuddy("Gabe", "Seals");

            LunchBuddy lunchBuddy3 = new LunchBuddy("Connor", "Sullivan");

            LunchBuddy lunchBuddy4 = new LunchBuddy("Richard", "Kincade");

            LunchBuddy lunchBuddy5 = new LunchBuddy("Brittany", "Key");


            List<LunchBuddy> companions = new List<LunchBuddy> { };
            companions.Add(lunchBuddy1);
            companions.Add(lunchBuddy2);
            companions.Add(lunchBuddy3);
            companions.Add(lunchBuddy4);
            companions.Add(lunchBuddy5);

            lunchBuddy1.Eat();
            lunchBuddy2.Eat("Steak");
            lunchBuddy3.Eat(companions);
            lunchBuddy4.Eat("Tacos", companions);
            Console.ReadLine();

        }
    }
}
