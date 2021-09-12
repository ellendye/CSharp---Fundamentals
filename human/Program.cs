using System;

namespace human
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        // add a public "getter" property to access health
        public int Health
        {
            get { return health; }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
            Console.WriteLine($"{Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {health}");
        }
        // Add a constructor to assign custom values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int h)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = h;
            Console.WriteLine($"{Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {health}");
        }
        // Build Attack method
        public int Attack(Human target)
        {
            target.health -= (Strength *5);
            return target.Health;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Ellen");
            Human human2 = new Human("Bob", 3,4,5,100);
            Console.WriteLine(human1.Attack(human2));
        }
    }
}
