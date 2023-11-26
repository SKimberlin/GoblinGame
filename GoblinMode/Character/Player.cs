using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using GoblinMode.Item;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GoblinMode.Character
{
    internal class Player : Character
    {
        public enum MoleSign
        {
            Skulker,
            Toiler,
            Ally,
            Brawler
        }
        int level;
        float exp;
        MoleSign moleSign;
        // Skills:

        int pickpocket;
        int locksmith;
        int mining;
        int dodge;
        int barter;
        int medic;

        // Weapon Proficiencies:
        int melee;
        int sword;
        int dagger;
        int bow;
        int staff;
        int axe;
        int mace;
        int shield;

        // Strength
        // Stealth
        // Endurance
        // Charisma/Trickery
        // Intelligence/Resourcefulness
        // Agility
        // Luck/Treasure finding

        // Goblin mole signs
        // The Skulker
        // The Toiler
        // The Ally
        // The Brawler

        public bool Read(string filename)
        {
            string json = File.ReadAllText(filename);

            Player character = JsonSerializer.Deserialize<Player>(json);

            this.name = character.name;
            //this.portrait = character.portrait;
            //this.inventory = character.inventory;
            this.power = character.power;
            this.sneak = character.sneak;
            this.mischief = character.mischief;
            this.cunning = character.cunning;
            this.skitter = character.skitter;
            this.gleam = character.gleam;


            return true;
        }
        public bool Write(string filename)
        {
            string json = JsonSerializer.Serialize(power);

            File.WriteAllText(filename, json);
            return true;

        }
    }
}
