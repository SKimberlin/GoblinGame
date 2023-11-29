using GoblinMode.Character;
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
    public partial class TownForm : Form
    {
        public TownForm()
        {
            InitializeComponent();

        }
        public void UpdateCombobox()
        {
            var enemies = Town.Instance.GetEnemies();

            if (enemies != null)
            {
                EnemyBox.DisplayMember = "name";

                EnemyBox.DataSource = enemies.ToList();

                EnemyBox.DisplayMember = "name";
            }
            else
            {
                EnemyBox.DataSource = null;
            }
        }

        private void GetHelp(object sender, EventArgs e)
        {
            Town.Instance.GetHelp();
        }

        private void Fight(object sender, EventArgs e)
        {
            Town.Instance.StartFight(EnemyBox.SelectedItem as NonPlayableCharacter);
        }

        private void TownForm_Shown(object sender, EventArgs e)
        {

            Town.Instance.EnemiesListChanged += Town_EnemiesListChanged;
            Town.Instance.PopulateEnemies(5);
        }

        private void Town_EnemiesListChanged(object sender, EventArgs e)
        {
            UpdateCombobox();
        }

        private void RefreshOpponents(object sender, EventArgs e)
        {
            Town.Instance.PopulateEnemies(5);
        }

        private void Rest(object sender, EventArgs e)
        {
            Town.Instance.Rest();
        }
    }
}
