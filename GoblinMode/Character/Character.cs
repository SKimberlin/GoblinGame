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
            SetDerived();
        }
        public void SetDerived()
        {
            maxHealth = 100 + (this.power * 0.5) + this.grit;
            pocketSize = 50 + this.power + this.grit;
        }

        public string name { get; set; }
        public Image portrait;
        public Weapon currentWeapon;
        private List<Item.Item> inventory;

        public List<Item.Item> GetItems() { return inventory; }

        public void AddItemToInventory(Item.Item newItem)
        {
            float totalWeight = 0;
            foreach (Item.Item item in inventory) 
            {
                totalWeight += item.weight;
            }
            if ((totalWeight + newItem.weight) < pocketSize) inventory.Add(newItem);
        }

        public void RemoveItemFromInventory(Item.Item item)
        {
            inventory.Remove(item);
        }
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
