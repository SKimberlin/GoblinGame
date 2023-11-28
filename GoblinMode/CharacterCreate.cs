using GoblinMode.Character;
using GoblinMode.Dialogue;
using GoblinMode.Item;
using System.Windows.Forms;

namespace GoblinMode
{
    public partial class CharacterCreate : Form
    {
        const int MaxPoints = 35;
        int Points = MaxPoints;
        UI.Player player;
        List<Image> portraits = new List<Image>();
        private int currentPortrait = 0;
        public CharacterCreate()
        {
            portraits.Add(Image.FromFile("Assets/GoblinMale.jpg"));
            portraits.Add(Image.FromFile("Assets/GoblinFemale.jpg"));
            InitializeComponent();
            PointsLeftCounter.Text = Points.ToString();
            CharacterPortrait.Image = portraits[currentPortrait];
            player = new UI.Player();

            NameBox.DataBindings.Add("Text", player, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            PowerPoints.DataBindings.Add("Text", player, "Power", false, DataSourceUpdateMode.OnPropertyChanged);
            SneakPoints.DataBindings.Add("Text", player, "Sneak", false, DataSourceUpdateMode.OnPropertyChanged);
            GritPoints.DataBindings.Add("Text", player, "Grit", false, DataSourceUpdateMode.OnPropertyChanged);
            MischiefPoints.DataBindings.Add("Text", player, "Mischief", false, DataSourceUpdateMode.OnPropertyChanged);
            CunningPoints.DataBindings.Add("Text", player, "Cunning", false, DataSourceUpdateMode.OnPropertyChanged);
            SkitterPoints.DataBindings.Add("Text", player, "Skitter", false, DataSourceUpdateMode.OnPropertyChanged);
            GleamPoints.DataBindings.Add("Text", player, "Gleam", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AddPoint(object sender, EventArgs e)
        {
            if (Points > 0)
            {
                switch (((Control)sender).Name)
                {
                    case "PowerAddButton":
                        player.Power++;
                        break;
                    case "SneakAddButton":
                        player.Sneak++;
                        break;
                    case "GritAddButton":
                        player.Grit++;
                        break;
                    case "MischiefAddButton":
                        player.Mischief++;
                        break;
                    case "CunningAddButton":
                        player.Cunning++;
                        break;
                    case "SkitterAddButton":
                        player.Skitter++;
                        break;
                    case "GleamAddButton":
                        player.Gleam++;
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
                        if (player.Power > 0)
                        {
                            player.Power--;
                            Points++;
                        }
                        break;
                    case "SneakRemoveButton":
                        if (player.Sneak > 0)
                        {
                            player.Sneak--;
                            Points++;
                        }
                        break;
                    case "GritRemoveButton":
                        if (player.Grit > 0)
                        {
                            player.Grit--;
                            Points++;
                        }
                        break;
                    case "MischiefRemoveButton":
                        if (player.Mischief > 0)
                        {
                            player.Mischief--;
                            Points++;
                        }
                        break;
                    case "CunningRemoveButton":
                        if (player.Cunning > 0)
                        {
                            player.Cunning--;
                            Points++;
                        }
                        break;
                    case "SkitterRemoveButton":
                        if (player.Skitter > 0)
                        {
                            player.Skitter--;
                            Points++;
                        }
                        break;
                    case "GleamRemoveButton":
                        if (player.Gleam > 0)
                        {
                            player.Gleam--;
                            Points++;
                        }
                        break;
                    case null:
                        break;
                }
                PointsLeftCounter.Text = Points.ToString();
            }
        }

        private void CreateCharacter(object sender, EventArgs e)
        {
            //if (Points != 0) return;
            //if (String.IsNullOrEmpty(player.Name)) return;

            Player gamePlayer = new Player()
            {
                name = player.Name,
                power = player.Power,
                sneak = player.Sneak,
                grit = player.Grit,
                mischief = player.Mischief,
                cunning = player.Cunning,
                skitter = player.Skitter,
                gleam = player.Gleam,
                portrait = portraits[currentPortrait]

            };
            Weapon weapon = new Weapon(0);
            weapon.damage = 2;
            weapon.name = "Fists";
            gamePlayer.currentWeapon = weapon;
            gamePlayer.SetDerived();
            CharacterManager.Instance.SetPlayer(gamePlayer);

            DialogueForm dialogueForm = new DialogueForm(CharacterManager.Instance.GetCharacterByID(0));
            dialogueForm.Show();
            this.Close();
        }

       

        private void NextImage(object sender, EventArgs e)
        {
            if (currentPortrait < portraits.Count - 1)
            {
                currentPortrait++;
                CharacterPortrait.Image = portraits[currentPortrait];
            }
        }

        private void PreviousImage(object sender, EventArgs e)
        {
            if (currentPortrait > 0)
            {
                currentPortrait--;
                CharacterPortrait.Image = portraits[currentPortrait];
            }
        }
    }
}