using GoblinMode.Character;
using GoblinMode.Dialogue;
using GoblinMode.Item;
using GoblinMode.UI;
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

            f1.Left = this.Left;
            f1.Top = this.Top;
            f1.Size = this.Size;

            this.Hide();
            f1.Show();
        }
        private void TempInit()
        {
            Town bogmireHollow = new Town();
            bogmireHollow.name = "Bogmire's Hollow";
            TownManager.Instance.AddTown(bogmireHollow);

            Character.NonPlayableCharacter npc1 = new Character.NonPlayableCharacter();
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

            Weapon weapon = new Weapon(0);
            weapon.damage = 10;
            npc1.currentWeapon = weapon;

            Character.NonPlayableCharacter npc2 = new Character.NonPlayableCharacter();
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

            Character.NonPlayableCharacter npc3 = new Character.NonPlayableCharacter();
            npc3.name = "Gobb Howard";
            npc3.portrait = Image.FromFile("Assets/GoblinMale.jpg");
            npc3.power = 999;
            npc3.sneak = 999;
            npc3.grit = 999;
            npc3.mischief = 999;
            npc3.cunning = 999;
            npc3.skitter = 999;
            npc3.gleam = 999;
            npc3.maxHealth = 100;
            npc3.currentHealth = 100;



            Dialogue.Dialogue dialogue = new Dialogue.Dialogue();
            Dialogue.Dialogue dialogueMom = new Dialogue.Dialogue();
            Dialogue.Dialogue dialogueNPC3 = new Dialogue.Dialogue();

            Response response1 = new Response();
            response1.responseText = "Where are you wanting to travel?";

            response1.formOptions.Add("Bogmire's Hollow", () => new TownForm(TownManager.Instance.GetTownByID(0)));
            response1.formOptions.Add("Through You!", () => new BattleForm(npc1));
            response1.formOptions.Add("Your moms house", () => new DialogueForm(npc2));

            Response dialogueStart = new Response();
            dialogueStart.responseText = "Hey goober, you finally arrived.";

            dialogueStart.dialogueOptions = new Dictionary<string, Response>();
            dialogueStart.dialogueOptions.Add("Hey Wise Gob", response1);

            dialogue.dialogueStart = dialogueStart;
            npc1.dialogue = dialogue;
            npc1.SetDerived();
            CharacterManager.Instance.AddCharacter(npc1);
            CharacterManager.Instance.AddCharacter(npc3);


            Response dialogueMomStart = new Response();
            dialogueMomStart.responseText = "Heya sweetie, how has the travelling been?";
            dialogueMom.dialogueStart = dialogueMomStart;
            npc2.dialogue = dialogueMom;
            
            TownManager.Instance.GetTownByID(0).residentIDs.Add(npc3.id);
        }
    }
}
