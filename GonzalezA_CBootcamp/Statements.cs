using System;
using System.Collections.Generic;
using System.Text;

namespace GonzalezA_CBootcamp
{
    public static class Statements
    {
        public static void BranchingIf()
        {
            int health = 5;
            Console.WriteLine("\t\nHealth: {0}", health);
            if (health < 9)
            {
                Console.WriteLine("!!!! Emergency !!!! User Death Imminent !!");
                Console.WriteLine("!!!! Seek Medical Attention !!!!");
            } else if (health >= 9 && health < 25)
            {
                Console.WriteLine("!! Vital Signs Critical !!");
                Console.WriteLine("!! Seek Medical Attention !!");
            } else
            {
                Console.WriteLine("Automatic Medical System Engaged");
                Console.WriteLine("Morphine Administered");
            }

            //one line test
            int b = 10;
            if(b > 5) 
                Console.WriteLine("\nYou live probably, good job :]");
        }

        public static void Switching()
        {
            int d = 57638489 % 6;

            string dude;
            string dialogue;

            switch(d)
            {
                case 1:
                    dude = "Joey";
                    dialogue = "\n*Joey stands in your path!";
                    break;
                case 2:
                    dude = "John";
                    dialogue = "\n*John asks for a raise!";
                    break;
                case 3:
                    dude = "Jerry";
                    dialogue = "\n*Jerry.";
                    break;
                case 4:
                    dude = "Jake";
                    dialogue = "\n*Jake squares up with the competition!";
                    break;
                case 5:
                    dude = "James";
                    dialogue = "\n*James chugs a [SCHOOL-FRIENDLY] beverage!";
                    break;
                default:
                    dude = "Jesse";
                    dialogue = "\n*Jesse cries in a corner!";
                    break;
            }

            Console.WriteLine("\n{0}", dialogue);

        }

        public static void ForLoop()
        {
            //used for counting (often with ints)
            //for (initialize the int; test expression; updater)
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("The value of i is {0}", i);
            }

            //nested forLoop
            //outer loop i
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Outer Loop {0}", i);
                //inner loop j
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("\tInner Loop {0}", j);
                }
            }
        }

        public static void WhileLoop()
        {
            //while (test-expression == true) {statements}
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine("The value of i is {0}", i);
                i++;
            }

            //do-while loop     TESTING gets done at the end of bottom of the loop
            int j = 0;
            do
            {
                Console.WriteLine("The value of j is {0}", 0);
                j++;
            } while (j < 5);

            do
            {
                Console.Write("Enter command: >");
            } while (Console.ReadLine() != "q");
        }

        public static void LoopingArrays()
        {
            string[] monster = new string[4];
            monster[0] = "Fred the Foe";
            monster[1] = "Thomas the Terrible";
            monster[2] = "Logan the Lacerator";
            monster[3] = "Ron the Ravenous";

            Console.WriteLine("Monster List:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\t{0}", monster[i]);
            }

        }

        public static void ForEachIterations()
        {
            List<string> swords = new List<string>();
            swords.Add("Keyblade");
            swords.Add("Buster Sword");
            swords.Add("Elucidator");
            swords.Add("Excalibur");

            Console.WriteLine("Swords in your inventory:");
            foreach(string s in swords)
            {
                Console.WriteLine("\t{0}", s);
            }

        }
    }
}
