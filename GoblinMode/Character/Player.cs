using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
