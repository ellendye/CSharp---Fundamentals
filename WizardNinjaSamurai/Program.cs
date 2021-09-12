using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
     
        public int Health
        {
            get { return health; }
            set { health = value;}
        }
     
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
     
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
     
    // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }
    class Ninja : Human
    {
        public Ninja(string name, int str, int intel, int hp) : base(name, str, intel, 175, hp)
        {
            Console.WriteLine($"{Name} strength: {Strength} intelligence: {Intelligence} dexterity: {Dexterity} health: {Health}");
        }
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int chanceOfDmg = rand.Next(1,6);
            int dmg = (5 * Dexterity);
            target.Health -= dmg;
            if (chanceOfDmg == 1){
                target.Health -= 10;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} AND got hit with an additional 10 points of damage!");
            }
            else{
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg}");
            }
            return target.Health;
        }
        public int Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine($"{Name} stole health from {target.Name}. {Name}'s health: {Health}. {target.Name}'s health: {target.Health}");
            return Health;
        }
    }
    class Wizard : Human
    {
        public Wizard(string name, int str, int dex) : base(name, str, 25, dex, 50)
        {
            Console.WriteLine($"{Name} strength: {Strength} intelligence: {Intelligence} dexterity: {Dexterity} health: {Health}");
        }
        public override int Attack(Human target)
        {
            int dmg = (5 * Intelligence);
            target.Health -= dmg;
            Health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg}");
            return target.Health;
        }
        public int Heal(Human target)
        {
            target.Health += (10* Intelligence);
            Console.WriteLine($"{Name} healed {target.Name} to {target.Health} health");
            return target.Health;
        }
        
    }
    class Samurai : Human
    {
        public Samurai(string name, int str, int intel, int dex) : base(name, str, intel, dex, 200)
        {
            Console.WriteLine($"{Name} strength: {Strength} intelligence: {Intelligence} dexterity: {Dexterity} health: {Health}");
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            if (target.Health < 50){
                target.Health = 0;
            }
            Console.WriteLine($"{Name} attacked {target.Name}. {target.Name} health: {target.Health}, {Name} health: {Health}");
            return target.Health;
        }
        public int Meditate()
        {
            Health = 200;
            Console.WriteLine($"{Name} health: {Health}");
            return Health;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Wizard ellen = new Wizard("Ellen", 2, 3);
            Ninja bob = new Ninja("Bob", 2, 4,100);
            Samurai sally = new Samurai("Sally", 6, 5,100);
            Console.WriteLine(ellen.Attack(sally));
            Console.WriteLine(ellen.Attack(bob));
            Console.WriteLine(bob.Attack(ellen));
            Console.WriteLine(sally.Attack(ellen));
            Console.WriteLine(ellen.Heal(bob));
            Console.WriteLine(ellen.Heal(sally));
            Console.WriteLine(sally.Meditate());
            Console.WriteLine(bob.Steal(sally));
        }
    }
}
