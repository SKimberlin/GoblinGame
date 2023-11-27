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
        Character.Player player;
        Character.NonPlayableCharacter npc;
        Random rand;
        public BattleController(Character.NonPlayableCharacter npc) 
        { 
            rand = new Random();
            this.player = CharacterManager.Instance.GetPlayer();
            this.npc = npc;
        }

        public void Attack(bool char1Turn)
        {
            if (char1Turn) 
            {
                npc.currentHealth -= player.currentWeapon.damage;
            }
            else
            {
                player.currentHealth -= npc.currentWeapon.damage;
            }
        }
        public void Block(bool char1Turn)
        {

        }
        public bool Run(bool char1Turn) 
        {
            if (player.skitter < (0.5 + rand.NextDouble()) * npc.skitter)
            {
                return true;
            }
            return false;
        }
    }
}
