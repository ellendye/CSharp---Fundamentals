using System;
using System.Collections.Generic;

namespace IronNinja
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull
        {
            get
            {
                if(calorieIntake >= 1500){return true;}
                else {return false;}
            }
        }
        public override void Consume(IConsumable item)
        {
        // provide override for Consume
            if(IsFull){
                Console.WriteLine($"Sorry you are full and can't eat anymore, Ninja");
            }
            else{
                ConsumptionHistory.Add(item);
                calorieIntake += item.Calories;
                if(item.IsSweet){
                    calorieIntake += 10;
                }
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}