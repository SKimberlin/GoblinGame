﻿using GoblinMode.Character;
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
        private Player player;
        private NonPlayableCharacter currentNPC;
        private Response currentResponse;
        private int x;
        public DialogueForm(NonPlayableCharacter npc)
        {
            InitializeComponent();
            if (CharacterManager.Instance.GetPlayer() != null)
            {
                player = CharacterManager.Instance.GetPlayer();
            }
            currentNPC = npc;
            if (currentNPC.dialogue != null) currentResponse = currentNPC.dialogue.dialogueStart;

            InitializeDialogue();
        }

        private void InitializeDialogue()
        {
            if (currentNPC.GetName() != null)
            {
                NPCNameBox.Text = currentNPC.GetName();
                NPCNameBox.Location = new Point(NPCNameBox.Location.X - NPCNameBox.Width, NPCNameBox.Location.Y);
            }
            if (currentNPC.GetPortrait() != null)
            {
                NPCPortrait.Image = currentNPC.GetPortrait();
            }
            if (player.GetName() != null)
            {
                PlayerNameBox.Text = player.GetName();
            }
            if (player.GetPortrait() != null)
            {
                PlayerPortrait.Image = player.GetPortrait();
            }
            x = DialogueBox.Location.X;
            DialogueBox.Location = new Point(x - DialogueBox.Width, DialogueBox.Location.Y);

            UpdateUI();
        }

        private void SubmitResponse(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PlayerResponseBox.Text)) return;

            currentResponse = currentResponse.dialogueOptions[PlayerResponseBox.Text];

            UpdateUI();
        }

        private void UpdateUI()
        {

            if (currentResponse == null) return;
            DialogueBox.Text = currentResponse.responseText;
            DialogueBox.Location = new Point(x - DialogueBox.Width, DialogueBox.Location.Y);
            PlayerResponseBox.Items.Clear();

            if (currentResponse.dialogueOptions != null)
            {
                foreach (var option in currentResponse.dialogueOptions.Keys)
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
