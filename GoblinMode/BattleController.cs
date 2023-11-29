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
        private static BattleController instance;
        private NonPlayableCharacter currentNPC;
        private System.Random random = new System.Random();
        private Player player;
        private BattleForm form;
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
        

        public void StartBattle(NonPlayableCharacter npc)
        {
            currentNPC = npc;
            player = CharacterManager.Instance.GetPlayer();
            playerAttackBuff = 1 + (player.power * 0.01f);
            npcAttackBuff = 1 + (currentNPC.power * 0.01f);
            playerDefenseBuff = Math.Min(1 - (player.grit * 0.01f), 0.20f);
            npcDefenseBuff = Math.Min(1 - (currentNPC.grit * 0.01f), 0.20f);
            
            form = new BattleForm();
            form.ShowDialog();
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
            if (currentNPC.getCurrentHealth() < 0) { Win(); }
            NPCTurn();
        }
        public void Block()
        {
            playerBlocking = true;
            NPCTurn();
        }
        public void Run()
        {
            if ((player.skitter + player.sneak) * (random.NextDouble() + 0.5) > currentNPC.skitter + currentNPC.sneak) 
            {
                Draw();
            }
            NPCTurn();
        }
        public void Inventory()
        {

        }

        private void NPCTurn()
        {
            double chance = random.NextDouble();
            {
                if (chance < 0.7)
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
                }
                else
                {
                    npcBlocking = true;
                }
            }
            if (player.getCurrentHealth() < 0) { Loss(); }
        }

        private void Win()
        {
            Town.Instance.KillEnemy(currentNPC);
            form.Close();
        }

        private void Loss()
        {
            LostGameForm lostForm = new LostGameForm();
            lostForm.ShowDialog();
            form.Close();
        }

        private void Draw()
        {
            form.Close();
        }
    }
}
