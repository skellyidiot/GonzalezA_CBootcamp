using System;
using System.Collections.Generic;
using System.Text;

namespace GonzalezA_CBootcamp
{
    public static class Storing                         //you cannot make objects from it because of "static"
    {
        //Enums                                         must be listed and set before methods
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

        //Methods
        public static void DemoVariables()
        {
            int playerID = 420;                         //int = 32 bit, max of ~4billion
            uint playerHealth = 69;                    //uint = only positive numbers
            long playerCount = 34567890876543;          //long = basically a really big int, 64 bit, max of ~9 quintillion numbers

            decimal playtime = 3.1415927089786387322498m;  //decimal = bigger float, more digits, uses "m" instead of "f" | double 

            bool isOnline = true;

            string username = "Skelly";
            char firstInitial = 'S';                    //char = only takes one letter/character, uses single quotation marks instead of two
            //firstInitial++;                           //++ on char makes the output the next character in ascii alphabet, -- uses the previous character
            Console.WriteLine(firstInitial);

            char beep = (char)7;
            Console.WriteLine(beep);                    //idk why but it makes windows beep/chime

            while (true)                                //tis a forever loop
            {
                Console.WriteLine(beep);
                beep++;
                Console.ReadLine();               
            }
        }

        public static void ReadingInput()
        {
            Console.Write("Enter Your Username: ");
            string name = Console.ReadLine();           //Console.ReadLine only reads strings
            Console.WriteLine("Hello, {0}. Logging in to the game...", name);

            Console.Write("\nEnter The World You Are In: ");
            int worldStage = Convert.ToInt32(Console.ReadLine());   //Converts things to different variable types

            int level = worldStage * 3;
            Console.WriteLine("Welcome to World {0}. You are level {1}.", worldStage, level);
        }

        public static void UsingArrays()
        {
            string[] enemyName = new string[5];         //bounds are 0-4 for the index
            enemyName[0] = "Riley the Ravenous";
            enemyName[1] = "Joseph the Joker";
            enemyName[2] = "Joseph the Jugular";
            enemyName[3] = "Ron the Raptor";
            enemyName[4] = "Nathan the Nasty";
            //enemyName[5] = "Ben the Butcher";         //overflows the bounds, will cause a crash

            int[] enemyHealth = new int[5] {10, 30, 35, 2, 90 };        //create AND initialize the array

            System.Random random = new System.Random();
            while(true)
            {
                int num = random.Next(5);
                Console.WriteLine("Rolled a {0}", num);
                enemyHealth[num]--;
                Console.WriteLine("{0} raised an axe and swung and now has {1} health", enemyName[num], enemyHealth[num]);
                //Console.ReadLine();
            }

        }

        public static void ConstantsAndEnums()
        {
            //Constants
            const double MaxLevel = 3.1415926535;
            Console.WriteLine("Max Level: {0}", MaxLevel);
            //MaxLevel = 3.14;                                    //const = cannot be changed after initially set, will never change 

            //Enums                                         //short for "enumerations"
            var dayOfWeek = Days.Sunday;                   //var =  untyped variable, can hold basically anything and converts depending on result
            //checkfor weekends
            if(dayOfWeek == Days.Saturday || dayOfWeek == Days.Sunday) {
                Console.WriteLine("Double XP Weekend!");
            } else
            {
                Console.WriteLine("Normal XP, too bad you missed your chance.");
            }
        }
    }
}
