using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //Will select a random restaurant name from a list of strings 
        //(List of restaurant names can come from anywhere), 
        //print to console that the buddy is at that restaurant, and also return the restaurant.
        public void Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} has arrived at {restaurant.Name}");
        }

        //Will output that the buddy ate that specific food at the office.
        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
        }

        //Will select a random restaurant name from a list of strings,
        //print to console that the buddy is at that restaurant,
        //and also output the first name of each lunch buddy in the specified list.

        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            var firstNames = new List<string> { };
            foreach (var companion in companions)
            {
                var first = companion.FirstName;
                firstNames.Add(first);
            }
            string buddies = string.Join(", ", firstNames);
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} with {buddies}.");
        }

        //Will select a random restaurant name from a list of strings,
        //print to console that the buddy at that restaurant, and ordered the specified food,
        //with the first name of the teammates specified in the list.

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var resturant = new Restaurant();
            var firstNames = new List<string> { };
            foreach (var companion in companions)
            {
                var first = companion.FirstName;
                firstNames.Add(first);
            }
            string buddies = string.Join(", ", firstNames);
            Console.WriteLine($"{FirstName} is at the restaurant and ordered {food} for {buddies}");
        }
    }
}
