using GoblinMode.Character;
using GoblinMode.Dialogue;
using UI;
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
    public partial class DialogueForm : Form
    {
        private DialogueCharacter playerUI;
        private DialogueCharacter currentNPCUI;
        private int x;
        public DialogueForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            x = DialogueBox.Location.X;
            playerUI = DialogueManager.Instance.GetPlayerUI();
            currentNPCUI = DialogueManager.Instance.GetCurrentNPCUI();

            NPCNameBox.DataBindings.Add("Text", currentNPCUI, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            PlayerNameBox.DataBindings.Add("Text", playerUI, "Name", false, DataSourceUpdateMode.OnPropertyChanged);

            NPCPortrait.Image = Image.FromFile(currentNPCUI.PortraitPath);
            PlayerPortrait.Image = Image.FromFile(playerUI.PortraitPath);

            NPCNameBox.Location = new Point(NPCNameBox.Location.X - (int)(NPCNameBox.Width) - 250, NPCNameBox.Location.Y);

            UpdateUI();
        }

        private void SubmitResponse(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PlayerResponseBox.Text)) return;

            DialogueManager.Instance.SetNewResponse(PlayerResponseBox.Text);

            UpdateUI();
        }

        private void UpdateUI()
        {

            if (DialogueManager.Instance.GetCurrentResponse() == null) return;
            DialogueBox.Text = DialogueManager.Instance.GetCurrentResponse().responseText;
            DialogueBox.Location = new Point(x - DialogueBox.Width, DialogueBox.Location.Y);
            PlayerResponseBox.Items.Clear();

            if (DialogueManager.Instance.GetCurrentResponse().dialogueOptions != null)
            {
                foreach (var option in DialogueManager.Instance.GetCurrentResponse().dialogueOptions.Keys)
                {
                    PlayerResponseBox.Items.Add(option);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
