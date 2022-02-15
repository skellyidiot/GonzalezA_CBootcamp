using System;
using System.Collections.Generic;
using System.Text;

namespace GonzalezA_CBootcamp
{
    public class Player
    {
        //Properties
        public int ID;               //0 is the real player. 1,2,3... are for monsters, NPCs, etc
        public string Name;
        public int Health;

        public Player(int iD, string name, int health)
        {
            ID = iD;
            Name = name;
            Health = health;
        }
    }
}
