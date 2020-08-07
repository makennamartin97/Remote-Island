using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Janitor : Hero, IPowerUp
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a cleanliness professional, or janitor I spose.");
        }

        public Janitor(string name) : base(name){
            Class="Janitor";
            Dexterity = 8;
            Speed = 8;
            Intelligence = 4;
            Strength = 6;
        }
        public override int Attack(Enemy target){
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Random rng = new Random();
            int dmg = rng.Next(0,Strength)*5;
            target.health -= dmg;
            Console.WriteLine($"EXTERMINAT The robot hits {target.Name} for {dmg} damage.");
            return target.health;
        }
        public int Clean(Hero target){
            Random rand = new Random();
            int amp = rand.Next(0, Speed) / 2;
            target.Speed += amp;
            Console.WriteLine("CLEAN Janitor enjoys cleaning up messes so people can move faster and have more strength");
            return target.health;
        
    }
    }
}