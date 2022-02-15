using System;
using System.Collections.Generic;
using System.Text;

namespace GonzalezA_CBootcamp
{
    public static class Operations
    {
        //Methods
        public static void Arithmetic()
        {
            int a = 9;
            int b = 6;
            int c;

            a++;                                    //increment operator (adds one)
            b--;                                    //decrement operator (subtracts one)

            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;

            c = a % b;                              //modulo operator ?~?
            //finds the remainder after a division: c = 10 % 5 = 10/5 = 2 R0    c = 0

            //Assignment
            a += b;                                 //takes current value of 'a' (10) and adds 'b' (5) to it
            a -= b;                                 //takes current value of 'a' (10) and subtracts 'b' (5) to it
            a *= b;                                 //you get what i'm saying
            a /= b;

            a /= 7;                                 //it doesn't round, only truncates
        }

        public static void Comparison()
        {
            int a = 10;
            int b = 42;
            Console.WriteLine(a == b);              // == means are they the same
                                                    //>=, > | <=, <
            Console.WriteLine(a != b);              // != means not equal


        }

        public static void Logic()
        {
            bool hasSword = false;
            bool hasMagic = false;

            //4 logic operators: NOT, AND, OR, XOR      (also NAND, NOR, we gonna ignore those)
            if (hasMagic) Console.WriteLine("Has a magic amulet");      //doesn't need curly braces if it's only one thing
            if (!hasMagic) Console.WriteLine("Does not have a magic amulet (L nerd + ratio + you fell off)");       //NOT operator: !
            if (hasMagic && hasSword) Console.WriteLine("VERY Dangerous. Has both magic and weapon");       //AND && is true when only BOTH bools are true
            if (hasSword || hasSword) Console.WriteLine("Can attack with magic OR with sword");     //OR || is true if at least one bool is true
            if (hasMagic ^ hasSword) Console.WriteLine("Only has ONE form of attack");      //XOR ^ is true when only ONE bool is true
            if (!hasMagic && !hasSword) Console.WriteLine("You cannot fight. R U N.");      //BOTH must be false
        }

        public static void Ternary()
        {
            //Flexing your code skills || Being lazy
            int a = 18;
            int b = 42;
            int c;

            //Ternary operator
            c = (a < b) ? a : b;                   //w h a t
            //c = (test) ? if true : if false        //doesn't explain much tbh
            Console.WriteLine(c);

            //An odd/even testerrr
            string Answer = (a % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine("{0} is {1}", a, Answer);
        }
    }
}
