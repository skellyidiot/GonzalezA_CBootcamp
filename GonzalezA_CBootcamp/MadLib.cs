using System;
using System.Collections.Generic;
using System.Text;

namespace GonzalezA_CBootcamp
{
    public static class MadLib
    {
        static float num1;
        static string numInch2;
        static int num2;

        public static void Execute()
        {
            

            Console.Write("Please enter an Animal. >");
            string ani1 = Console.ReadLine();

            AskNumber1:
            Console.Write("Please enter a Number. >");
            try
            {
                string numString = Console.ReadLine();
                num1 = float.Parse(numString);
                float numInch1 = num1 * 12;
                numInch2 = numInch1.ToString("0.00");
                
            } catch
            {
                Console.WriteLine("That's not a number! Try again.");
                goto AskNumber1;
            }

            Console.Write("Please enter an Adjective. >");
            string adj1 = Console.ReadLine();

            Console.Write("Please enter an Adjective. >");
            string adj2 = Console.ReadLine();

            Console.Write("Please enter a Noun that ends with 'ER'. >");
            string noun1 = Console.ReadLine();

            Console.Write("Please enter a Verb. >");
            string verb1 = Console.ReadLine();

        AskNumber2:
            Console.Write("Please enter a WHOLE Number. >");
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
            }catch
            {
                Console.WriteLine("That's not a whole number! Try again.");
                goto AskNumber2;
            }

            

            Console.WriteLine("\n--------------------------\n\n");
            Console.WriteLine("Did you know that {0}s grow to be {1} feet long? That's {2} inches long!", ani1, num1, numInch2);
            Console.WriteLine("{0} are very {1}, and are often called the {2} {3}s.", ani1, adj1, adj2, noun1);
            Console.WriteLine("They often stay together and {0} in groups of {1}.", verb1, num2);

            //num1.ToString("F");

            string num3 = (100 > num2) ? "much more aggressive to make up for the lack of buddies." : "much more friendly and chilled out.";

            //Console.WriteLine("Generally, if their group has less than {0} {1}s, they tend to be {2}\n\n\n", num2, ani1, num3);
        }
    }
}
