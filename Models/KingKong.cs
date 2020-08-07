using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class KingKong : Enemy
    {
        public override void Observe()
        {
            Console.WriteLine($"Monkey Noises{Name}, Monkey Noises.");
        }

        public KingKong(string name) : base(name){
            Strength = 10;
            Dexterity = 1;
            Intelligence = 3;
            Speed = 3;
            health = 25;

        }
        public override int Attack(Hero target){
            Console.ForegroundColor = ConsoleColor.Red;
            Random rng = new Random();
            int dmg = rng.Next(0,Strength)*5;
            target.health -= dmg;
            Console.WriteLine($"SMASH King Kong hits {target.Name} for {dmg} damage.");
            return target.health;
        }

        public int ApeHug(Enemy target){
            Random rand = new Random();
            int dmg = rand.Next(0, Strength) * 2;
            target.health += dmg;
            Console.WriteLine("GARGHHH KingKong Heals after a big hug from his girlfriend");
            return target.health;
        }
    }
}
