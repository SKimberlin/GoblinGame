using GoblinMode.Item;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GoblinMode.Character
{
    public class Character
    {
        const int STAT_MAX = 999;
        
        public Character() { }
        public Character(int power, int sneak, int grit, int mischief, int cunning, int skitter, int gleam) 
        { 
            this.power = power; this.sneak = sneak; this.grit = grit; this.mischief = mischief; this.cunning = cunning; this.skitter = skitter; this.gleam = gleam;
            pocketSize = (float)(100 + (this.power * 0.2) + (this.grit * 0.1));
        }
        public void SetDerived()
        {
            maxHealth = 100 + (this.power * 0.5) + (this.grit * 1);
            pocketSize = 50 + this.power + this.grit;
        }

        public string name { get; set; }
        public string portraitPath;
        public Image portrait;
        public Weapon currentWeapon;
        List<Item.Item> inventory;
        // Main Stats
        public int power { get; set; }    // Strength
        public int sneak { get; set; }    // Stealth
        public int grit { get; set; }     // Endurance
        public int mischief { get; set; } // Charisma/Trickery
        public int cunning { get; set; }  // Intelligence/Resourcefulness
        public int skitter { get; set; }  // Agility
        public int gleam { get; set; }    // Luck/Treasure finding

        // Derived Stats
        float pocketSize;
        public double maxHealth;
        public float currentHealth;

    }
}
