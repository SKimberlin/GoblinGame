using GoblinMode.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode
{
    internal class BattleController
    {
        Random rand;
        public BattleController() 
        { 
            rand = new Random();
        }

        public void Attack(Character.Character target, Character.Character attacker)
        {
            target.currentHealth -= attacker.currentWeapon.damage;
        }
        public void Block()
        {

        }
        public bool Run(Character.Character target, Character.Character attacker) 
        {
            if (target.skitter < (0.5 + rand.NextDouble()) * attacker.skitter)
            {
                return true;
            }
            return false;
        }
    }
}
