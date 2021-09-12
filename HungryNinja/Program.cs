using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
        public string Display()
        {
            return $"{Name}, {Calories}, {IsSpicy}, {IsSweet}";
        }
    }
    class Buffet
        {
            public List<Food> Menu;
            //constructor
            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("Waffles", 1000, false, true),
                    new Food("Bacon", 750, false, false),
                    new Food("Eggs", 100, false, false),
                    new Food("Jalepeno Poppers", 1200, true, false),
                    new Food("Ice Cream", 1100, false, true),
                    new Food("Buffalo wings", 900, true, false),
                    new Food("Nachos", 1500, true, false)
                };
            }  
            public Food Serve()
            {
                Random rand = new Random();
                Food Served = Menu[rand.Next(0,Menu.Count)];
                return Served;
            }
        }
        class Ninja
        {
            private int calorieIntake;
            public List<Food> FoodHistory;
            // add a constructor
            public Ninja(){
                calorieIntake = 0;
                FoodHistory = new List<Food>();
            }
            // add a public "getter" property called "IsFull"
            public bool isFull
            {
                get 
                {
                    if(calorieIntake > 1200){return true;}
                    else {return false;}
                }
            }
            // build out the Eat method
            public void Eat(Food item)
            {
                if (isFull){
                    Console.WriteLine($"Current calorie cout: {calorieIntake}. Ninja you're full and you can't eat anymore");
                }
                else{
                    FoodHistory.Add(item);
                    calorieIntake += item.Calories;
                    Console.WriteLine(item.Display());
                }
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Buffet myBuff = new Buffet();
            Ninja newNinja = new Ninja();
            newNinja.Eat(myBuff.Serve());
            newNinja.Eat(myBuff.Serve());
            newNinja.Eat(myBuff.Serve());
        }
    }
}
