using GoblinMode.Character;
using GoblinMode.Dialogue;
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
        private NonPlayableCharacter currentNPC;
        private Response currentResponse;
        private int x;
        public DialogueForm(NonPlayableCharacter npc)
        {
            InitializeComponent();
            currentNPC = npc;
            currentResponse = currentNPC.dialogue.dialogueStart;

            InitializeDialogue();
        }

        private void InitializeDialogue()
        {
            if (currentNPC.name != null)
            {
                NPCNameBox.Text = currentNPC.name;
            }
            if (currentNPC.portrait != null)
            {
                NPCPortrait.Image = currentNPC.portrait;
            }
            DialogueBox.Text = currentResponse.responseText;
            x = DialogueBox.Location.X;
            DialogueBox.Location = new Point(x - DialogueBox.Width, DialogueBox.Location.Y);
            foreach (var option in currentResponse.dialogueOptions.Keys)
            {
                PlayerResponseBox.Items.Add(option);
            }


        }

        private void SubmitResponse(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PlayerResponseBox.Text)) return;
            currentResponse = currentResponse.dialogueOptions[PlayerResponseBox.Text];
            PlayerResponseBox.Items.Clear();
            DialogueBox.Text = currentResponse.responseText;
            DialogueBox.Location = new Point(x - DialogueBox.Width, DialogueBox.Location.Y);
            if (currentResponse.dialogueOptions != null)
            {
                foreach (var option in currentResponse.dialogueOptions.Keys)
                {
                    PlayerResponseBox.Items.Add(option);
                }
            }
        }
    }
}
