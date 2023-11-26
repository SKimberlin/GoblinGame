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
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
            TempInit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CharacterCreate f1 = new CharacterCreate();
            this.Hide();
            f1.ShowDialog();

            f1.Left = this.Left;
            f1.Top = this.Top;
            f1.Size = this.Size;

            this.Close();
        }
        private void TempInit()
        {
            Town bogmireHollow = new Town();
            bogmireHollow.name = "Bogmire's Hollow";
            NonPlayableCharacter npc1 = new NonPlayableCharacter();
            npc1.id = 1;
            npc1.name = "Wise Old Gob";
            npc1.portrait = Image.FromFile("assets/mogus.jpg");
            npc1.power = 999;
            npc1.sneak = 999;
            npc1.grit = 999;
            npc1.mischief = 999;
            npc1.cunning = 999;
            npc1.skitter = 999;
            npc1.gleam = 999;
            npc1.maxHealth = 100;
            npc1.currentHealth = 100;

            NonPlayableCharacter npc2 = new NonPlayableCharacter();
            npc2.id = 2;
            npc2.name = "Wise Old Gob's Mom";
            npc2.portrait = Image.FromFile("assets/mogus.jpg");
            npc2.power = 999;
            npc2.sneak = 999;
            npc2.grit = 999;
            npc2.mischief = 999;
            npc2.cunning = 999;
            npc2.skitter = 999;
            npc2.gleam = 999;
            npc2.maxHealth = 100;
            npc2.currentHealth = 100;



            Dialogue.Dialogue dialogue = new Dialogue.Dialogue();
            Dialogue.Dialogue dialogueMom = new Dialogue.Dialogue();

            Response response1 = new Response();
            response1.responseText = "Where are you wanting to travel?";

            response1.formOptions.Add("Bogmire's Hollow", () => new TownForm(bogmireHollow));
            response1.formOptions.Add("Through You!", () => new BattleForm(npc1));
            response1.formOptions.Add("Your moms house", () => new DialogueForm(npc2));

            Response dialogueStart = new Response();
            dialogueStart.responseText = "Hey goober, you finally arrived.";

            dialogueStart.dialogueOptions = new Dictionary<string, Response>();
            dialogueStart.dialogueOptions.Add("Hey Wise Gob", response1);

            dialogue.dialogueStart = dialogueStart;
            npc1.dialogue = dialogue;
            CharacterManager.Instance.AddCharacter(npc1);


            Response dialogueMomStart = new Response();
            dialogueMomStart.responseText = "Heya sweetie, how has the travelling been?";
            dialogueMom.dialogueStart = dialogueMomStart;
            npc2.dialogue = dialogueMom;
            
        }
    }
}
