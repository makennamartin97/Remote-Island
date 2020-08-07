using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public abstract class Hero : IPowerUp
    {
        public string Name;
        public string Class;
        public int Intelligence;
        public int Dexterity;
        public int Strength;
        public int Speed;
        public int health;
        public string Location;
        public bool CaveDone;
        public bool ApeDone;
        public bool DinoDone;

        public Hero(string name)
        {
            Name = name;
            Location = "The Beach";
            Intelligence = 5;
            Dexterity = 5;
            Strength = 5;
            Speed = 5;
            health = 100;
            CaveDone=false;
            ApeDone=false;
            DinoDone=false;
        }

        public abstract void SayName();

        public virtual void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\nLocation: {Location}\nIntelligence: {Intelligence}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
        }

        public abstract int Attack(Enemy target);

        public virtual void Power(Hero reciever)
        {
            health += 50;
        }
    }
}