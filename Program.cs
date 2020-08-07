using System;
using cSharp_NinjaRemoteIsland.Models;

namespace cSharp_NinjaRemoteIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleRed("********NINJA: REMOTE ISLAND********");

            Hero player = PlayerSetup();
            
            ConsoleRed($"You, {player.Name}, were part of the inaugural Coding Dojo alumni Cruise!  Unfortunately, there was an incident involving a wrong turn and a huge wave.  You blacked out and woke up to find yourself on a remote mysterious island.\n\nNow you must conquer the secrets of the Island and gather what info you may.  What dangers and mysteries lurk within the jungle island?  Will help ever come?  Why are there so many ninjas all over the place?\n\nPress Enter to Start");

            ConsoleKey key  = Console.ReadKey(true).Key;
            while(key != ConsoleKey.Enter)
            {
                key  = Console.ReadKey(true).Key;
            }
            Console.WriteLine("BEGIN YOUR ADVENTURE HERE!!!");

            Hero partner = MakeAFriend(player);
            string firstchoice = AFork();
            if (firstchoice=="1"){
                Spelunking(player, partner);
            }
            else if(firstchoice=="2"){
                Jurassic(player, partner);
            }
            string secondchoice = WhatNext();
            if (secondchoice=="1"){
                Ape(player, partner);
            }
            else if(secondchoice=="2"){
                Jurassic(player, partner);
            }
            if (firstchoice=="1"){
                if(secondchoice=="1"){
                    Jurassic(player,partner);
                }
                else{
                    Ape(player,partner);
                }
            }
            else{
                Spelunking(player,partner);
            }
            WinOrLose(player, partner);



            //write a method that will create other team mates.

            // make a game(while) loop to run your game
        }

        static void ConsoleRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static Hero PlayerSetup()
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            string choice = "0";

            while( choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Please type the number of the hero you would like to be?\n1. Ninja\n2. Teacher\n3. Janitor");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case("1"):
                    Ninja ninjaHero = new Ninja(name);
                    return ninjaHero;
                case("2"):
                    // Change Ninja to another class of hero.
                    Teacher teacherHero = new Teacher(name);
                    return teacherHero;
                case("3"):
                    // Change Ninja to another class of hero.
                    Janitor janitorHero = new Janitor(name);
                    return janitorHero;
            }
            return null;
        }
        static Hero MakeAFriend(Hero player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You awaken to find the wreckage of the ship, far farther inland than you could've imagined. A few scragglers have stuck by the ship but most aren't interested in acting just yet.\n\n Enter to continue");
            ConsoleKey key  = Console.ReadKey(true).Key;
            while(key != ConsoleKey.Enter)
            {
                key  = Console.ReadKey(true).Key;
            }

            if(player.Class!="Teacher"){
                Console.WriteLine("You look to your left and see a young woman with shoulder-length brown hair and turtleshell round framed glasses. If stereotypes alone didn't get you there, she looks to be taking attendance of the rest of the survivors and you make the inference she is a teacher.\n\n Press Enter");
                ConsoleKey partkey  = Console.ReadKey(true).Key;
                while(partkey != ConsoleKey.Enter)
                {
                    partkey  = Console.ReadKey(true).Key;
                }
            }
            if(player.Class!="Ninja"){
                Console.WriteLine("To your right, at first you don't see much of anything. Just some shadows cast by the wreckage of the ship, maybe a good place to nap. After closer inspection, you can see a figure hanging from a few beams of the wreckage, does he have a sword?\n\n Press Enter");
                ConsoleKey partkey  = Console.ReadKey(true).Key;
                while(partkey != ConsoleKey.Enter)
                {
                    partkey  = Console.ReadKey(true).Key;
                }
            }
            if(player.Class!="Janitor"){
                Console.WriteLine("In front of you a man is sleeping, he looks to be in his 50's with a thick curly mustache. He snores as you approach. He looks to be dressed in a blue jumpsuit with a cursive nametag that says 'Rodney'. If you had to guess, he's a janitor from the ship \n\n Press Enter");
                ConsoleKey partkey  = Console.ReadKey(true).Key;
                while(partkey != ConsoleKey.Enter)
                {
                    partkey  = Console.ReadKey(true).Key;
                }
            }
            string choice = "0";

            while( choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Please type the number of the partner you would like to select?\n1. Ninja\n2. Teacher\n3. Janitor");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case("1"):
                    Console.WriteLine("Adrien the ninja joins your party.");
                    Ninja ninjaPartner = new Ninja("Adrien");
                    return ninjaPartner;
                case("2"):
                    // Change Ninja to another class of hero.
                    Console.WriteLine("Clara the teacher joins your party.");
                    Teacher teacherPartner = new Teacher("Clara");
                    return teacherPartner;
                case("3"):
                    // Change Ninja to another class of hero.
                    Console.WriteLine("Rodney the janitor joins your party.");
                    Janitor janitorPartner = new Janitor("Rodney");
                    return janitorPartner;
            }
            return null;
        }
        static string AFork(){
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Now that you've got an adventuring buddy where would you like to go?\n\n");
            string choice = "0";
            while( choice != "1" && choice != "2")
            {
                Console.WriteLine("Where would you like to go?\n1. Cave\n2. Jungle");
                choice = Console.ReadLine();
            };
            return choice;
        }
        static string WhatNext(){
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Happy to exit the cave, you reach a forked pathway. One leads into what appears to be a large clearing with stadium seating. Another leads deep into the vines and trees of the jungle\n\n Which path do you choose?");
            string choice = "0";
            while( choice != "1" && choice != "2")
            {
                Console.WriteLine("Which pathway will you select?\n1. Clearing\n2. Jungle");
                choice = Console.ReadLine();
            };
            return choice;
        }
        static void Spelunking(Hero player, Hero partner)
        {
            player.Location = "The Spooky Cave";
            Robot caveRobot = new Robot("caveRobot");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("It's getting dark and you approach a cave to figure out what the plan's gonna be. As you walk inside, 2 red lights appear out of the darkness. It's a robot!?\n\n Enter to continue");
            ConsoleKey key  = Console.ReadKey(true).Key;
            while(key != ConsoleKey.Enter)
            {
                key  = Console.ReadKey(true).Key;
            }
            caveRobot.Observe();
            Console.WriteLine("You greet the robot and ask for it's name, but it is not ally. It starts racing at you from the end of the cave at 100mph. You have 2 choices: 1.) to run or 2.) to fight.\n\n What do you choose?");
            string choice = "0";
            while( choice != "1" && choice != "2")
            {
                Console.WriteLine("?\n1. Run away\n2. Fight");
                choice = Console.ReadLine();
            };
            if( choice == "1")
            {
                Console.WriteLine("You start running as fast as possible out of tbe cave and into the water. The robot follows into the water and instantly dies.");
                caveRobot.health = 0;
                Console.WriteLine("You realize this place probably has a lot more enemies around. ");
                player.CaveDone = true;
            }
            else if(choice == "2") {
                Console.WriteLine("You make the brave decision of fighting the robot.");
                while(caveRobot.health>0&&player.health>0){
                    caveRobot.Attack(player);
                    player.Attack(caveRobot);
                    partner.Attack(caveRobot);
                    Console.WriteLine("Enter to continue");
                    ConsoleKey fightkey  = Console.ReadKey(true).Key;
                    while(fightkey != ConsoleKey.Enter)
                    {
                        fightkey  = Console.ReadKey(true).Key;
                    }
                    if (player.health<25){
                        Console.WriteLine("Your health is less than 25, you have been given a Power up");
                        player.Power(player);
                    }
                }
                if(player.health>0){
                    Console.WriteLine("You killed the robot");
                    player.CaveDone = true;
                    if (player.health<25){
                        Console.WriteLine("Your health is less than 25, you have been given a Power up");
                        player.Power(player);
                    }
                }
                else{
                    Console.WriteLine("Somehow you died to the very first and weakest enemy, this is tragic.");
                }
            }
        }
        static void Jurassic(Hero player, Hero partner)
        {
            player.Location = "Jurassic Forest";
            Dinosaur dino1 = new Dinosaur("Dino");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player.Location}");
            Console.WriteLine("You emerge from an ancient jungle temple to find a Tyranosaurus Rex writhing in anger, as it charges toward you in a torrential hurricane of speed and power.");
            dino1.Attack(player);
            player.Attack(dino1);
            dino1.EatGrass();
            Console.WriteLine("Press Enter to fight the Dinosaur!");
            ConsoleKey key  = Console.ReadKey(true).Key;
            while(key != ConsoleKey.Enter)
            {
                key  = Console.ReadKey(true).Key;
            }
            while(dino1.health>0&&player.health>0)
            {
                dino1.Attack(player);
                player.Attack(dino1);
            }
            if(player.health > 0)
            {
                Console.WriteLine("You killed the dinosaur!");
                if (player.health<25){
                    Console.WriteLine("Your health is less than 25, you have been given a Power up");
                    player.Power(player);
                }
                player.DinoDone = true;
            }
            else{
                Console.WriteLine("You have been killed by the dinosaur :(");
            }
        }
        static void Ape(Hero player, Hero partner)
        {
            player.Location = "King Kong's Coliseum";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{player.Location}");
            KingKong kk1 = new KingKong("King Kong");
            Console.WriteLine("You enter a dilapidated arena full of old apes, thirsty for blood\n\n Press Enter for the fight of your life.");
            ConsoleKey key  = Console.ReadKey(true).Key;
            while(key != ConsoleKey.Enter)
            {
                key  = Console.ReadKey(true).Key;
            }
            while(kk1.health>0 && player.health>0) 
            {
                kk1.Attack(player);
                player.Attack(kk1);
            }
            if(player.health > 0)
            {
                Console.WriteLine("You killed King Kong!");
                
                if(player.health < 25)
                {
                    Console.WriteLine("Your health is less than 25, you have been given a power up.");
                    player.Power(player);
                }
                
            }
            else
            {
                Console.WriteLine("You have been killed by King Kong");
            };
                player.ApeDone = true;
            
        }
        static void WinOrLose(Hero player, Hero partner)
        {
            if( player.CaveDone == true && player.ApeDone == true && player.DinoDone == true && player.health > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("You are laying on the beach exhausted after defeating a dinosaur, King Kong, and a robot. You hear a faint sound in the distance. Could that be.. a helicopter?! You and the team have been rescued!");

                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("******************************** Game Over *********************************");
            }
            else{
                Console.WriteLine("You absolute fool, how dare you fail our dojo. You bring great disrespect to our family and souls. SHAME SHAME ON YOU AND YOUR BLOODLINE. RODNEY WOULDN'T HAVE LET THIS HAPPEN.");
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("******************************** Game Over *********************************");
            }
        }
    }
}
