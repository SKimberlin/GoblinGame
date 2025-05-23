using GoblinMode.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GoblinMode.Character
{
    public abstract class Character
    {

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
            currentHealth = maxHealth;
        }

        public string name { get; set; }
        private Image portrait;
        private Weapon currentWeapon;
        private List<Item.Item> inventory = new List<Item.Item>();
        private float totalWeight;

        public List<Item.Item> GetItems() { return inventory; }

        
        // Main Stats
        public int power { get; set; }    // Strength
        public int sneak { get; set; }    // Stealth
        public int grit { get; set; }     // Endurance
        public int mischief { get; set; } // Charisma/Trickery
        public int cunning { get; set; }  // Intelligence/Resourcefulness
        public int skitter { get; set; }  // Agility
        public int gleam { get; set; }    // Luck/Treasure finding

        // Derived Stats
        private float pocketSize;
        private double maxHealth;
        private double currentHealth;


        public string GetName() { return name; }
        public void SetName(string name) {  this.name = name; }
        public Image GetPortrait() { return portrait; }
        public void SetPortrait(Image portrait) { this.portrait = portrait;}
        public double getCurrentHealth() { return currentHealth; }
        public void TakeDamage(double damage) { currentHealth -= damage; }
        public void SetHealthToMax() { currentHealth = maxHealth; }
        public double getMaxHealth() { return maxHealth; }
        public double getPocketSize() { return pocketSize; }
        public Weapon getCurrentWeapon() { return currentWeapon; }
        public void setCurrentWeapon(Weapon weapon) {  currentWeapon = weapon; }

        public void AddItemToInventory(Item.Item newItem)
        {
            totalWeight = 0;
            foreach (Item.Item item in inventory)
            {
                totalWeight += item.GetWeight();
            }
            if ((totalWeight + newItem.GetWeight()) < pocketSize) inventory.Add(newItem);
        }

        public void RemoveItemFromInventory(Item.Item item)
        {
            if (item.IsRemoveable()) inventory.Remove(item);
        }

    }
}
