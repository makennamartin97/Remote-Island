using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public abstract class Enemy
    {
        public string Name;
        public int Intelligence;
        public int Dexterity;
        public int Strength;
        public int Speed;
        public int health;

        public Enemy(string name)
        {
            Name = name;
            Intelligence = 5;
            Dexterity = 5;
            Strength = 5;
            Speed = 5;
            health = 25;
        }

        public abstract void Observe();
        public abstract int Attack(Hero target);

        public virtual void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\nIntelligence: {Intelligence}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
        }
    }
}