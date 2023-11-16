using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.Character
{
    internal class Character
    {
        const int STAT_MAX = 999;
        
        public Character() { }
        public Character(int power, int sneak, int grit, int mischief, int cunning, int skitter, int gleam) 
        { 
            this.power = power; this.sneak = sneak; this.grit = grit; this.mischief = mischief; this.cunning = cunning; this.skitter = skitter; this.gleam = gleam;
            pocketSize = (float)(100 + (this.power * 0.2) + (this.grit * 0.1));
        }
        
        string name;
        Image portrait;
        List<Item.Item> inventory;
        // Main Stats
        int power;    // Strength
        int sneak;    // Stealth
        int grit;     // Endurance
        int mischief; // Charisma/Trickery
        int cunning;  // Intelligence/Resourcefulness
        int skitter;  // Agility
        int gleam;    // Luck/Treasure finding

        // Derived Stats
        float pocketSize;
        int maxHealth;


    }
}
