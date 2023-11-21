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
        
        public string name { get; set; }
        public Image portrait;
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
        int maxHealth;

        public virtual bool Read(string filename)
        {
            string json = File.ReadAllText(filename);

            Character character = JsonSerializer.Deserialize<Character>(json);

            this.name = character.name;
            this.portrait = character.portrait;
            this.inventory = character.inventory;
            this.power = character.power;
            this.sneak = character.sneak;
            this.mischief = character.mischief;
            this.cunning = character.cunning;
            this.skitter = character.skitter;
            this.gleam = character.gleam;


            return true;
        }

    }
}
