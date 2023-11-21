using GoblinMode.Character;
using GoblinMode.Dialogue;

namespace GoblinMode
{
    public partial class CharacterCreate : Form
    {
        const int MaxPoints = 35;
        int Points = MaxPoints;
        int Power = 0;
        int Sneak = 0;
        int Grit = 0;
        int Mischief = 0;
        int Cunning = 0;
        int Skitter = 0;
        int Gleam = 0;
        Player.MoleSign moleSign = 0;
        public CharacterCreate()
        {
            InitializeComponent();
            PointsLeftCounter.Text = Points.ToString();
            Directory.SetCurrentDirectory("../../..");
            NonPlayableCharacter nonPlayableCharacter = new NonPlayableCharacter();
            nonPlayableCharacter.Read("Assets/Test_Character.json");
            Console.WriteLine(nonPlayableCharacter.power);
        }

        private void AddPoint(object sender, EventArgs e)
        {
            if (Points > 0)
            {
                switch (((Control)sender).Name)
                {
                    case "PowerAddButton":
                        Power++;
                        PowerPoints.Text = Power.ToString();
                        break;
                    case "SneakAddButton":
                        Sneak++;
                        SneakPoints.Text = Sneak.ToString();
                        break;
                    case "GritAddButton":
                        Grit++;
                        GritPoints.Text = Grit.ToString();
                        break;
                    case "MischiefAddButton":
                        Mischief++;
                        MischiefPoints.Text = Mischief.ToString();
                        break;
                    case "CunningAddButton":
                        Cunning++;
                        CunningPoints.Text = Cunning.ToString();
                        break;
                    case "SkitterAddButton":
                        Skitter++;
                        SkitterPoints.Text = Skitter.ToString();
                        break;
                    case "GleamAddButton":
                        Gleam++;
                        GleamPoints.Text = Gleam.ToString();
                        break;
                    case null:
                        break;
                }
                Points--;
                PointsLeftCounter.Text = Points.ToString();
            }
        }

        private void RemovePoint(object sender, EventArgs e)
        {
            if (Points < MaxPoints)
            {
                switch (((Control)sender).Name)
                {
                    case "PowerRemoveButton":
                        if (Power > 0)
                        {
                            Power--;
                            PowerPoints.Text = Power.ToString();
                            Points++;
                            PointsLeftCounter.Text = Points.ToString();
                        }
                        break;
                    case "SneakRemoveButton":
                        if (Sneak > 0)
                        {
                            Sneak--;
                            SneakPoints.Text = Sneak.ToString();
                            Points++;
                            PointsLeftCounter.Text = Points.ToString();
                        }
                        break;
                    case null:
                        break;
                }
                
            }
        }

        private void CreateCharacter(object sender, EventArgs e)
        {
            /*
            if (Points != 0)
            {
                return;
            }
            if (String.IsNullOrEmpty(NameBox.Text))
            {
                return;
            }*/
            Player player = new Player();
            NameBox.DataBindings.Add("Text", player, "name", false);
            PowerPoints.DataBindings.Add("Text", player, "power", false);
            SneakPoints.DataBindings.Add("Text", player, "sneak", false);
            GritPoints.DataBindings.Add("Text", player, "grit", false);
            MischiefPoints.DataBindings.Add("Text", player, "mischief", false);
            CunningPoints.DataBindings.Add("Text", player, "cunning", false);
            SkitterPoints.DataBindings.Add("Text", player, "skitter", false);
            GleamPoints.DataBindings.Add("Text", player, "gleam", false);

            NonPlayableCharacter nonPlayableCharacter = new NonPlayableCharacter();
            Dialogue.Dialogue dialogue = new Dialogue.Dialogue();
            Response response = new Response();
            response.dialogueOptions = new Dictionary<string, Response>();
            response.responseText = "Hello pisspot!";
            response.dialogueOptions.Add("Hello!", new Dialogue.Response { responseText = "Response to Hello!" });
            response.dialogueOptions.Add("Go away!", new Dialogue.Response { responseText = "Response to Go away!" });
            dialogue.dialogueStart = response;
            nonPlayableCharacter.dialogue = dialogue;
            nonPlayableCharacter.name = "Schmi";
            nonPlayableCharacter.portrait = Image.FromFile("assets/mogus.jpg");

            DialogueForm dialogueForm = new DialogueForm(nonPlayableCharacter);
            dialogueForm.ShowDialog();
        }

        private void MoleSignClick(object sender, EventArgs e)
        {
            if (((Control)sender).Name == "NextMoleSign")
            {
                moleSign++;
            }
            else
            {
                moleSign--;
            }
            if (((int)moleSign) > 3) { moleSign = 0; }
            else if (((int)moleSign) < 0) { moleSign = (Player.MoleSign)3; }

        }
    }
}