using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Buffet
        {
            public List<IConsumable> Menu;
            //constructor
            public Buffet()
            {
                Menu = new List<IConsumable>()
                {
                    new Food("Waffles", 250, false, true),
                    new Food("Bacon", 750, false, false),
                    new Food("Eggs", 100, false, false),
                    new Food("Jalepeno Poppers", 1200, true, false),
                    new Food("Ice Cream", 600, false, true),
                    new Food("Buffalo wings", 700, true, false),
                    new Food("Nachos", 550, true, false),
                    new Drink("Pepsi", 300, true, false),
                    new Drink("Water", 0, false, false),
                    new Drink("Orange Juice", 125, false, true),
                    new Drink("Spicy Marg", 675, true, false)
                };
            }  
            public IConsumable Serve()
            {
                Random rand = new Random();
                IConsumable Served = Menu[rand.Next(0,Menu.Count)];
                return Served;
            }
        }
}