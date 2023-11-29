using GoblinMode.Character;
using GoblinMode.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode
{
    public static class Random
    {
        static private System.Random random = new System.Random();
        public static NonPlayableCharacter GetRandomNPC(float diffuculty)
        {
            NonPlayableCharacter enemy = new NonPlayableCharacter();
            switch (random.Next(0, 3))
            {
                case 0:
                    enemy.name = "Angry Goober";
                    break;
                case 1:
                    enemy.name = "Hateful Goober";
                    break;
                case 2:
                    enemy.name = "Wacky Goober";
                    break;
                case 3:
                    enemy.name = "Sassy Goober";
                    break;
            }
            switch (random.Next(0, 1))
            {
                case 0:
                    enemy.portrait = Image.FromFile("assets/GoblinMale.jpg");
                    break;
                case 1:
                    enemy.portrait = Image.FromFile("assets/GoblinFemale.jpg");
                    break;
            }
            enemy.power = (int)(diffuculty * random.NextDouble());
            enemy.sneak = (int)(diffuculty * random.NextDouble());
            enemy.grit = (int)(diffuculty * random.NextDouble());
            enemy.mischief = (int)(diffuculty * random.NextDouble());
            enemy.cunning = (int)(diffuculty * random.NextDouble());
            enemy.skitter = (int)(diffuculty * random.NextDouble());
            enemy.gleam = (int)(diffuculty * random.NextDouble());
            enemy.SetDerived();
            enemy.setCurrentWeapon(GetRandomWeapon());
            return enemy;
        }

        public static Item.Item GetRandomItem()
        {
            Item.Item item;
            switch (random.Next(0, 2))
            {
                case 0:
                    
                    break;
                case 1:                    
                    break;
                default:
                    break;
            }
            return null;
        }

        static public Weapon GetRandomWeapon()
        {
            Weapon item = new Weapon();
            string name = "";
            switch (random.Next(0, 9))
            {
                case 0:
                    name = "GODS ONLY";
                    break;
                case 1:
                    name = "Moss covered";
                    break;
                case 2:
                    name = "Fierce";
                    break;
                case 3:
                    name = "Enchanted";
                    break;
                case 4:
                    name = "Ancient";
                    break;
                case 5:
                    name = "Mysterious";
                    break;
                case 6:
                    name = "Cursed";
                    break;
                case 7:
                    name = "Radiant";
                    break;
                case 8:
                    name = "Shadowy";
                    break;
                default:
                    name = "Unknown";
                    break;
            }
            switch (random.Next(0, 2))
            {
                case 0:
                    name += " Sword";
                    break;
                case 1:
                    name += " Spear";
                    break;
                case 2:
                    name += " Axe";
                    break;
            }
            item.SetWeight((float)random.NextDouble() * 10);
            item.SetWorth((float)random.NextDouble() * 100);
            item.SetDamage((float)random.NextDouble() * 5 * (float)( 1 + (0.1 * CharacterManager.Instance.GetPlayer().GetLevel())));
            return item;
        }

        static public HealingItem GetRandomHealingItem()
        {
            return null;
        }
    }
}
