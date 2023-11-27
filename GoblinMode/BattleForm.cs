using GoblinMode.Character;
using GoblinMode.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinMode
{
    public partial class BattleForm : Form
    {
        private NonPlayableCharacter currentNPC;
        Player player;
        BattleController battle;
        Form endForm;
        Random random =new Random();
        public BattleForm(NonPlayableCharacter npc)
        {
            InitializeComponent();
            player = CharacterManager.Instance.GetPlayer();
            currentNPC = npc;
            if (currentNPC.portrait != null) NPCPortrait.Image = currentNPC.portrait;
            if (currentNPC.name != null) NPCNameBox.Text = currentNPC.name;
            battle = new BattleController(currentNPC);
            UpdateUI();
        }

        private void Attack(object sender, EventArgs e)
        {
            battle.Attack(true);
            UpdateUI();
            NPCTurn();
        }

        private void Inventory(object sender, EventArgs e)
        {

        }

        private void Run(object sender, EventArgs e)
        {
            if(battle.Run(true))
            {
                endForm.ShowDialog();
            }
            NPCTurn();
        }

        private void Block(object sender, EventArgs e)
        {
            battle.Block(true);
            UpdateUI();
            NPCTurn();
        }

        private void UpdateUI()
        {
            NPCHealth.Text = currentNPC.currentHealth.ToString() + "/" + currentNPC.maxHealth.ToString();
            PlayerHealth.Text = player.currentHealth.ToString() + "/" + player.maxHealth.ToString();
        }
        private void NPCTurn()
        {
            double npcChoice = random.NextDouble();
            
            if (npcChoice < 0.6)
            {
                battle.Attack(false);
            }
            else if (npcChoice < 0.9)
            {
                battle.Block(false);
            }
            else
            {
                battle.Run(false);
            }
            UpdateUI();
        }
    }
}
