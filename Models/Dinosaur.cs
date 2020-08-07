using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Dinosaur : Enemy
    {
        public override void Observe()
        {
            Console.WriteLine($"rawr {Name}, rawr");
        }

        public Dinosaur(string name) : base(name){
            Intelligence = 10;
        }
        public override int Attack(Hero target){

            Random rng = new Random();
            int dmg = rng.Next(0,Strength)*5;
            target.health -= dmg;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Dinosaur has attacked {target.Name}'s for {dmg} health");
            return target.health;
        }

        public int EatGrass (){
            Random rand = new Random();
            int amp = rand.Next(0, Intelligence) / 2;
            health += amp;
            Console.WriteLine("YUM T-rex eats grass and feels healthier");
            return health;
    }

    }
}
