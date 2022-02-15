using System;
using System.Collections.Generic;
using System.Text;

namespace GonzalezA_CBootcamp
{
    public static class MiniDC
    {
        //Method
        public static void StartDC()
        {
            Console.Clear();
            Console.WriteLine("Mini Dungeon Crawler. Welcome to D'nal!");
            Console.Write("\n\tWhat is your name, dear player? >");
            string pName = Console.ReadLine();
            Player player = new Player(0, pName, 40);

            //Create some monsters...
            Player[] monster = new Player[6];
            monster[0] = new Player(0, "", 0);
            monster[1] = new Player(1, "Goblo the Giant", 25);
            monster[2] = new Player(2, "The Wizard of D'nal", 5);
            monster[3] = new Player(3, "Landon the Lancer", 15);
            monster[4] = new Player(4, "Griffin the Gryfin", 20);
            monster[5] = new Player(5, "Greg", 125);

            //Create some locations
            int maxX = 11;
            int maxY = 11;
            //create a 2D array of locations
            Location[,] location = new Location[maxX, maxY];  //make lots of null locations

            location[5, 5] = new Location("Home", "You sit in a comfy chair near a fire.", 0);
            location[4, 4] = new Location("Getel", "A small town with a magical fountain.", 2);
            location[7, 7] = new Location("A Huge Cavern", "You hear rumbling and stomping sounds.", 5);
            location[9, 7] = new Location("A Weeping Willow", "The branches of the willow sooth you.", 0);


            //Place the player at home
            int pX = 5;
            int pY = 5;

            //Create a dice to roll...
            Random dice = new Random();

            //Game start!
            while(true)                                       //basically a forever loop
            {
                //display location and health
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("HEALTH: {0}", player.Health);
                Console.WriteLine("LOCATION: {0}, {1}", pX, pY);

                //display details about locations and monsterrrrs
                if(location[pX,pY] != null)
                {
                    Console.WriteLine("\t**** {0} ****", location[pX, pY].LocationName);
                    Console.WriteLine("\t**** {0} ****", location[pX, pY].Description);

                    //monster detection
                    if (location[pX, pY].MonsterID != 0)
                    {
                        int mID = location[pX, pY].MonsterID;
                        Console.WriteLine("\t!!!! You encountered {0} with health of {1} !!!!", monster[mID].Name, monster[mID].Health);

                        //Battle
                        int damageToPlayer = dice.Next(1, 8);
                        int damageToMonster = dice.Next(1, 8);
                        //Deal Damage
                        player.Health -= damageToPlayer;
                        monster[mID].Health -= damageToMonster;
                        //Show results
                        Console.WriteLine("\t!!! You take {0} damage, your health is now {1} !!!", damageToPlayer, player.Health);
                        Console.WriteLine("\t!!! Monster takes {0} damage and monster's health is now {1}", damageToMonster, monster[mID].Health);

                        if(player.Health <= 0)
                        {
                            Console.WriteLine("You are dead. No big surprise.");
                            return;
                        }
                        if(monster[mID].Health <= 0)
                        {
                            Console.WriteLine("\t!!! You have slain {0} !!!", monster[mID].Name);
                            location[pX, pY].MonsterID = 0;         //teleports monster out of room, basically sent to the void and no longer exists
                        }

                    }   //monsterID != 0

                }   //location != null

                //healing or other options
                if(pX == 9 && pY == 7)
                {
                    Console.WriteLine("You can feel your wounds start to heal!");
                    player.Health += dice.Next(-3,6);

                    //cap health
                    if (player.Health >= 60) player.Health = 60;
                }

                //Ask user for commands
                Console.Write("Please enter a command. >");
                string cmd = Console.ReadLine().ToLower().Trim();
                if(cmd == "q" || cmd == "quit" || cmd == "exit")
                {
                    Console.WriteLine("Thank you for playing.");
                    return;
                }

                //movement
                if (cmd == "n" || cmd == "north" || cmd == "gonorth") pY--;
                if (cmd == "s" || cmd == "south" || cmd == "gosouth") pY++;
                if (cmd == "e" || cmd == "east" || cmd == "goeast") pX++;
                if (cmd == "w" || cmd == "west" || cmd == "gowest") pX--;

                //Solve the offworld problem
                pX = Math.Clamp(pX, 0, maxX - 1);
                if (pY < 1) pY = maxY - 1;      //wrapping around
                if (pY > maxY-1) pY = 0;        //wrapping around

                //map
                if (cmd == "m" || cmd == "map") Location.DrawMap(location, pX, pY);
            }   //end of while(true)
        }
    }
}
