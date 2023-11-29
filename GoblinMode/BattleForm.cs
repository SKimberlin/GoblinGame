using GoblinMode.Character;
using GoblinMode.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinMode
{

    public partial class BattleForm : Form
    {
        private int healthX;
        private UI.Combatant currentNPCUI;
        private UI.Combatant playerUI;

        public BattleForm()
        {
            InitializeComponent();
            InitializeUI();
        }
        private void InitializeUI()
        {
            playerUI = BattleController.Instance.GetPlayerUI();
            currentNPCUI = BattleController.Instance.GetCurrentNPCUI();

            NPCNameBox.DataBindings.Add("Text", currentNPCUI, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            NPCPortrait.DataBindings.Add("Image", currentNPCUI, "Portrait", false, DataSourceUpdateMode.OnPropertyChanged);
            NPCCurrentHealth.DataBindings.Add("Text", currentNPCUI, "CurrentHealth", false, DataSourceUpdateMode.OnPropertyChanged);
            NPCMaxHealth.DataBindings.Add("Text", currentNPCUI, "MaxHealth", false, DataSourceUpdateMode.OnPropertyChanged);

            PlayerNameBox.DataBindings.Add("Text", playerUI, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            PlayerPortrait.DataBindings.Add("Image", playerUI, "Portrait", false, DataSourceUpdateMode.OnPropertyChanged);
            PlayerCurrentHealth.DataBindings.Add("Text", playerUI, "CurrentHealth", false, DataSourceUpdateMode.OnPropertyChanged);
            PlayerMaxHealth.DataBindings.Add("Text", playerUI, "MaxHealth", false, DataSourceUpdateMode.OnPropertyChanged);

            NPCNameBox.Location = new Point(NPCNameBox.Location.X - (int)(NPCNameBox.Width * 1.5), NPCNameBox.Location.Y);
            healthX = NPCCurrentHealth.Location.X;

        }

        private void Attack(object sender, EventArgs e)
        {
            BattleController.Instance.Attack();
        }

        private void Run(object sender, EventArgs e)
        {
            BattleController.Instance.Run();
        }

        private void Block(object sender, EventArgs e)
        {
            BattleController.Instance.Block();
        }


    }
}
