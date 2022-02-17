using System;
using System.Collections.Generic;
using System.Text;

namespace GonzalezA_CBootcamp
{
    public static class StringWork
    {
        public static void StringFeatures()
        {
            Console.Write("Please enter some text: ");
            string text = Console.ReadLine().Trim();
            if (String.IsNullOrEmpty (text))
            {
                Console.WriteLine("You do realize empty space does not count as text, right?.");
            } else
            {
                Console.WriteLine("Wow. You entered \"{0}\". How original.", text);
                string query = text.StartsWith("C#") ? "does" : "doesn't";
                Console.WriteLine("Hm, {0} {1} start with C#. Interesting.", text, query);

                query = text.EndsWith("cool") ? "does" : "doesn't";
                Console.WriteLine("{0} also {1} end with cool", text, query);

                query = text.Contains("is") ? "does" : "doesn't";
                Console.WriteLine("{0} {1} contain 'is'.", text, query);
                //to filter text: grep or "regular expressions"
            }
        }

        public static void Manipulate()
        {
            Console.Write("Please enter some text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Wow. You entered \"{0}\". How original.", text);
            Console.WriteLine("Your text is {0} long.", text.Length);
            text = text.Trim();                                                     //btw whatever.Trim() removes the tabs and spaces from end result
            Console.WriteLine("Your trimmed text is {0} long.", text.Length);

            string upper = text.ToUpper();
            string lower = text.ToLower();
            Console.WriteLine(upper);
            Console.WriteLine(lower);

            text = text.PadLeft(15,'/');
            Console.WriteLine(text);
            text = text.PadRight(30, '\\');
            Console.WriteLine(text);
        }

        public static void JoinAndCompare()
        {
            string[] a = new string[3] { "Alpha", "Beta", "Gamma" };
            string s = String.Concat(a[0], a[2]);                               //string.concat(list, list, etc);
            Console.WriteLine(s);
            s = a[0] + a[1];                                                          //same thing as concat basically, things like excel prefer concat
            Console.WriteLine(s);

            s = String.Join(", ", a[0], a[1], a[2]);                            //string.join("seperator", list, list, etc);
            Console.WriteLine(s);
            s = string.Join(", ", a);
            Console.WriteLine(s);

            int num = string.Compare("Apples", "Oranges");  //string.compare("something", "whatever"); = if first input is before second input alphabetically (ascii table values)
            Console.WriteLine(num);

            Console.WriteLine("apples" == "oranges");
        }

        public static void FindingSubStrings ()
        {
            string phrase = "The quick brown fox jumped over the lazy dog and the cat and the mouse.".ToLower();
            string searchTerm = "the";
            int num = phrase.IndexOf(searchTerm,0);
            Console.WriteLine(num);
        }

        public static void Formatting()
        {
            //Specifiers: G=general, F=fixedPoint, N=Number with commas at the 1000s
            //C=currency, P=percent, 000.00000=zeroPadding

            float number = 1234.5678f;
            string sN = number.ToString("G");
            Console.WriteLine(sN);

            //!!!!!!SPLITTING!!!!!!! VER IMPORTANT!!!!!!!!!!!
            string data = "Alpha,Bravo,Charlie,Delta,Echo,Foxtrot";
            string[] items = data.Split(',');

            //Console.WriteLine(items[3]);
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void DateStrings()
        {
            //while (true)
            //{
            //    DateTime now = DateTime.Now;
            //    Console.WriteLine(now);
            //    Console.WriteLine(now.DayOfWeek);
            //    Console.WriteLine(now.DayOfYear);
            //}

            DateTime birthday = new DateTime(2004, 12, 11);
            Console.WriteLine(birthday.DayOfWeek);
            Console.WriteLine(birthday.AddYears(51).DayOfWeek);
        }
    }
}
