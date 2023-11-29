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
    public partial class InventoryForm : Form
    {
        Item.Weapon selectedWeapon;
        Item.HealingItem selectedHealingItem;
        public InventoryForm()
        {
            InitializeComponent();
            InitializeComboboxes();
            UpdateCurrentWeapon();
        }

        private void InitializeComboboxes()
        {
            foreach (Item.Weapon item in CharacterManager.Instance.GetPlayer().GetItems())
            {
                WeaponBox.DisplayMember = "name";
                WeaponBox.Items.Add(item);
            }
            foreach (Item.HealingItem item in CharacterManager.Instance.GetPlayer().GetItems())
            {
                HealingItemBox.DisplayMember = "name";
                HealingItemBox.Items.Add(item);
            }
        }

        private void UpdateCurrentWeapon()
        {
            WeaponNameLabel.Text = CharacterManager.Instance.GetPlayer().getCurrentWeapon().GetName();
            WeaponDamageLabel.Text = CharacterManager.Instance.GetPlayer().getCurrentWeapon().GetDamage().ToString();
        }

        private void ViewWeapon(object sender, EventArgs e)
        {
            if (WeaponBox.SelectedItem != null)
            {
                selectedWeapon = (Item.Weapon)WeaponBox.SelectedItem;
            }
        }

        private void ViewHealingItem(object sender, EventArgs e)
        {
            if (HealingItemBox.SelectedItem != null)
            {
                selectedHealingItem = (Item.HealingItem)WeaponBox.SelectedItem;
            }
        }
    }
}
