using System;

namespace IronNinja
{
    class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull
        {
            get
            {
                if(calorieIntake >= 1200){return true;}
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
                if(item.IsSpicy){
                    calorieIntake -= 5;
                }
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}