using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Robot : Enemy
    {
        public override void Observe()
        {
            Console.WriteLine($"01001000 01100101 01101100 01101100 01101111 00100000 01001101 01111001 00100000 01101110 01100001 01101101 01100101 00100000 01101001 01110011 00100000 {Name}, 01100001 01101110 01100100 00100000 01001001 00100111 01101101 00100000 01100001 00100000 01110010 01101111 01100010 01101111 01110100 00101110");
        }

        public Robot(string name) : base(name){
            Intelligence = 10;
            Dexterity = 2;
            Strength = 6;
            Speed = 2;
        }
        public override int Attack(Hero target){
            Console.ForegroundColor = ConsoleColor.Red;
            Random rng = new Random();
            int dmg = rng.Next(0,Strength)*5;
            target.health -= dmg;
            Console.WriteLine($"EXTERMINATE EXTERMINATE! The robot hits {target.Name} for {dmg} damage.");
            return target.health;
        }
        public int InfoDump(Hero target){
            Console.ForegroundColor = ConsoleColor.Red;
            Random rng = new Random();
            int dmg = rng.Next(0,Intelligence)/3;
            target.Intelligence-=dmg;
            Console.WriteLine($"Earsplitting dialup noises emit from the Robot's mouth, confusing {target.Name} and reducing their Intelligence by {dmg}.");
            return target.health;
        }
    }
}