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
        Town town;
        public TownForm(Town town)
        {
            InitializeComponent();
            this.town = town;
            TownNameBox.Text = town.name;

            foreach (int id in town.residentIDs)
            {
                NPCSelect.Items.Add(CharacterManager.Instance.GetCharacterByID(id).name);
            }
        }

        private void GoToMap(object sender, EventArgs e)
        {
            new MapForm().Show();
            this.Close();
        }

        private void SelectNPC(object sender, EventArgs e)
        {
            DialogueForm form = new DialogueForm(CharacterManager.Instance.GetCharacterByName(NPCSelect.Text));
            form.Show();
            Close();
        }
    }
}
