using GoblinMode.Character;

namespace GoblinMode
{
    public partial class Form1 : Form
    {
        const int MaxPoints = 35;
        int StartingPoints = MaxPoints;
        int Power = 0;
        int Sneak = 0;
        int Grit = 0;
        int Mischief = 0;
        int Cunning = 0;
        int Skitter = 0;
        int Gleam = 0;
        Player.MoleSign moleSign = 0;
        public Form1()
        {
            InitializeComponent();
            PointsLeftCounter.Text = StartingPoints.ToString();

        }

        private void AddPoint(object sender, EventArgs e)
        {
            if (StartingPoints > 0)
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
                    case null:
                        break;
                }
                StartingPoints--;
                PointsLeftCounter.Text = StartingPoints.ToString();
            }
        }

        private void RemovePoint(object sender, EventArgs e)
        {
            if (StartingPoints < MaxPoints)
            {
                switch (((Control)sender).Name)
                {
                    case "PowerRemoveButton":
                        if (Power > 0)
                        {
                            Power--;
                            PowerPoints.Text = Power.ToString();
                        }
                        break;
                    case "SneakRemoveButton":
                        if (Sneak > 0)
                        {
                            Sneak--;
                            SneakPoints.Text = Sneak.ToString();
                        }
                        break;
                    case null:
                        break;
                }
                StartingPoints++;
                PointsLeftCounter.Text = StartingPoints.ToString();
            }
        }

        private void CreateCharacter(object sender, EventArgs e)
        {
            Player player = new Player();

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