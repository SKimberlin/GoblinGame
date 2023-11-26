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
        public BattleForm(NonPlayableCharacter npc)
        {
            InitializeComponent();
            player = new Player();
            Weapon weapon = new Weapon(0);
            weapon.damage = 10;
            player.currentWeapon = weapon;
            player.maxHealth = 400;
            player.skitter = 5;
            currentNPC = npc;
            if (currentNPC.portrait != null) NPCPortrait.Image = currentNPC.portrait;
            if (currentNPC.name != null) NPCNameBox.Text = currentNPC.name;
            battle = new BattleController();
            Update();
        }

        private void Attack(object sender, EventArgs e)
        {
            battle.Attack(currentNPC, player);
            Update();
            
            
        }

        private void Inventory(object sender, EventArgs e)
        {

        }

        private void Run(object sender, EventArgs e)
        {
            if(battle.Run(currentNPC, player))
            {
                endForm.ShowDialog();
            }
        }

        private void Block(object sender, EventArgs e)
        {

        }

        private void Update()
        {
            NPCHealth.Text = currentNPC.currentHealth.ToString() + "/" + currentNPC.maxHealth.ToString();
            PlayerHealth.Text = player.currentHealth.ToString() + "/" + player.maxHealth.ToString();
        }
    }
}
