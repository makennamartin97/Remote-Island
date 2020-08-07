using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Ninja : Hero, IPowerUp
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a ninja.");
        }

        public Ninja(string name) : base(name){
            Class="Ninja";
            Dexterity = 10;
        }
        public override int Attack(Enemy target){
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Random rng = new Random();
            int dmg = rng.Next(0,Strength)*5;
            target.health -= dmg;
            Console.WriteLine($"Swhip! A ninja star sticks into {target.Name} for {dmg} damage.");
            return target.health;
        }
        public int Steal(Hero target){
            Random rand = new Random();
            int dex = rand.Next(0, Dexterity) / 2;
            target.Dexterity += dex;
            Console.WriteLine("HIYA Ninja steals and in the process increases his dexterity");
            return target.health;
    }
    }
}