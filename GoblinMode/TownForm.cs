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
                EnemyBox.DisplayMember = "Name";

                EnemyBox.DataSource = enemies.ToList();

                EnemyBox.DisplayMember = "Name";
            }
            else
            {
                EnemyBox.DataSource = null;
            }
        }

        private void OpenShop(object sender, EventArgs e)
        {
            Shop.Shop.Instance.OpenShopForm();
            Town.Instance.CloseTownForm();
        }

        private void GetHelp(object sender, EventArgs e)
        {
            DialogueForm form = new DialogueForm(CharacterManager.Instance.GetCharacterByID(0));
            form.ShowDialog();
        }

        private void LevelUp(object sender, EventArgs e)
        {

        }

        private void Fight(object sender, EventArgs e)
        {
            NonPlayableCharacter selectedNPC = EnemyBox.SelectedItem as NonPlayableCharacter;

            BattleController.Instance.StartBattle(selectedNPC);
        }

        private void TownForm_Shown(object sender, EventArgs e)
        {

            Town.Instance.EnemiesListChanged += Town_EnemiesListChanged;
            Town.Instance.PopulateEnemies(5);
        }

        private void OpenInventory(object sender, EventArgs e)
        {
            /*
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.ShowDialog();*/
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
            CharacterManager.Instance.GetPlayer().SetHealthToMax();
        }
    }
}
