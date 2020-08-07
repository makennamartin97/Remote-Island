using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Teacher : Hero, IPowerUp
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a ninja.");
        }

        public Teacher(string name) : base(name){
            Class="Teacher";
            Dexterity = 10;
            Intelligence = 8;
        }
        public override int Attack(Enemy target){
            Console.ForegroundColor = ConsoleColor.Red;
            Random rng = new Random();
            int dmg = rng.Next(0,Strength)*5;
            target.health -= dmg;
            Console.WriteLine($"Like a ruler to the back of the head! {Name} hits {target.Name} for {dmg} damage.");
            return target.health;
        }

        public int Teach(Hero target){
            Random rand = new Random();
            int smarts = rand.Next(0, Strength) * 5;
            target.Intelligence += smarts;
            Console.WriteLine("TEACHERS TEACH Teaching students to make them smarter");
            return target.health;
    }
    }
}