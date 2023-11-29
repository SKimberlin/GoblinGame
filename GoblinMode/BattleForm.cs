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
        private int healthX;
        NonPlayableCharacter currentNPC;

        public BattleForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void Attack(object sender, EventArgs e)
        {
            BattleController.Instance.Attack();
            UpdateUI();
        }

        private void Run(object sender, EventArgs e)
        {
            BattleController.Instance.Run();
            UpdateUI();
        }

        private void Block(object sender, EventArgs e)
        {
            BattleController.Instance.Block();
            UpdateUI();
        }

        private void InitializeUI()
        {
            NPCNameBox.Text = BattleController.Instance.GetEnemy().name;
            NPCNameBox.Location = new Point(NPCNameBox.Location.X - NPCNameBox.Width, NPCNameBox.Location.Y);
            NPCPortrait.Image = BattleController.Instance.GetEnemy().portrait;

            PlayerNameBox.Text = BattleController.Instance.GetPlayer().name;
            PlayerPortrait.Image = BattleController.Instance.GetPlayer().portrait;

            healthX = NPCHealth.Location.X;

            UpdateUI();
        }

        private void UpdateUI()
        {

            NPCHealth.Text = Math.Round(BattleController.Instance.GetEnemy().getCurrentHealth(), 2) + "/" + BattleController.Instance.GetEnemy().getMaxHealth();
            NPCHealth.Location = new Point(healthX - NPCHealth.Width, NPCHealth.Location.Y);
            PlayerHealth.Text = Math.Round(BattleController.Instance.GetPlayer().getCurrentHealth(), 2) + "/" + BattleController.Instance.GetPlayer().getMaxHealth();

        }


    }
}
