using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        private List<string> _resturants { get; } = new List<string>
        { 
            "Longhorn",
            "Logans",
            "Taco Bell"
        };
        public string Name { get; set; }

        public Restaurant()
        {
            Random random = new Random();

            Name = _resturants[random.Next(_resturants.Count)];
        }
    }
}
