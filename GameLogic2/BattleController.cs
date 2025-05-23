using GoblinMode.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode
{
    public class BattleController
    {
        private UI.Combatant playerUI;
        private UI.Combatant currentNPCUI;
        private static BattleController instance;
        private NonPlayableCharacter currentNPC;
        private System.Random random = new System.Random();
        private Player player;
        private bool playerBlocking;
        private bool npcBlocking;
        private float playerAttackBuff;
        private float npcAttackBuff;
        private float playerDefenseBuff;
        private float npcDefenseBuff;
        public NonPlayableCharacter GetEnemy() { return currentNPC; }
        public Player GetPlayer() { return player; }
        public static BattleController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BattleController();
                }
                return instance;
            }
        }
        

        public void SetBattle(NonPlayableCharacter npc)
        {
            currentNPC = npc;
            player = CharacterManager.Instance.GetPlayer();
            playerAttackBuff = 1 + (player.power * 0.01f);
            npcAttackBuff = 1 + (currentNPC.power * 0.01f);
            playerDefenseBuff = Math.Min(1 - (player.grit * 0.01f), 0.20f);
            npcDefenseBuff = Math.Min(1 - (currentNPC.grit * 0.01f), 0.20f);

            currentNPCUI = new UI.Combatant(npc.GetName(), npc.GetPortrait(), npc.getMaxHealth(), npc.getCurrentHealth() ); 
            playerUI = new UI.Combatant(player.GetName(), player.GetPortrait(), player.getMaxHealth(), player.getCurrentHealth() );
        }

        public void Attack()
        {
            double damage = player.getCurrentWeapon().GetDamage() * playerAttackBuff;
            if (npcBlocking)
            {
                currentNPC.TakeDamage(damage * 0.5 * npcDefenseBuff);
                npcBlocking = false;
            }
            else
            {
                currentNPC.TakeDamage(damage);
            }
            currentNPCUI.CurrentHealth = Math.Round(currentNPC.getCurrentHealth(), 2);
        }
        public void Block()
        {
            playerBlocking = true;
        }
        public bool Run()
        {
            if ((player.skitter + player.sneak) * (random.NextDouble() + 0.5) > currentNPC.skitter + currentNPC.sneak) 
            {
                return true;
            }
            return false;
        }

        public void NPCTurn()
        {
            double chance = random.NextDouble();
            {
                if (chance < 0.80)
                {
                    double damage = currentNPC.getCurrentWeapon().GetDamage() * npcAttackBuff;
                    if (playerBlocking)
                    {
                        player.TakeDamage(damage * 0.5 * playerDefenseBuff);
                        playerBlocking = false;
                    }
                    else
                    {
                        player.TakeDamage(damage);
                    }
                    playerUI.CurrentHealth = Math.Round(player.getCurrentHealth(), 2);
                }
                else
                {
                    npcBlocking = true;
                }
            }
        }

        public bool Win()
        {
            if (currentNPC.getCurrentHealth() < 0)
            {
                Town.Instance.KillEnemy(currentNPC);
                return true;
            }
            return false;
        }

        public bool Loss()
        {
            if (player.getCurrentHealth() < 0) return true;
            return false;
        }
        public UI.Combatant GetPlayerUI() { return playerUI; }
        public UI.Combatant GetCurrentNPCUI() { return currentNPCUI; }
    }
}
