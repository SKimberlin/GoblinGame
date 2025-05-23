namespace TestMaui
{
    public partial class CharacterCreatePage : ContentPage
    {
        int count = 0;
        const int MaxPoints = 35;
        int Points = MaxPoints;
        UI.Character player;
        List<string> portraits = new List<string>();
        private int currentPortrait = 0;
        public CharacterCreatePage()
        {
            InitializeComponent();
            portraits.Add("Assets/GoblinMale.jpg");
            portraits.Add("Assets/GoblinFemale.jpg");
            PointsLeftCounter.Text = Points.ToString();
            CharacterPortrait.Source = portraits[currentPortrait];
            player = new UI.Character();

            NameBox.SetBinding(Entry.TextProperty, nameof(player.Name), BindingMode.TwoWay);
            PowerPoints.SetBinding(Label.TextProperty, nameof(player.Power), BindingMode.TwoWay);
            SneakPoints.SetBinding(Label.TextProperty, nameof(player.Sneak));
            GritPoints.SetBinding(Label.TextProperty, new Binding(nameof(player.Grit)));
            MischiefPoints.SetBinding(Label.TextProperty, new Binding(nameof(player.Mischief)));
            CunningPoints.SetBinding(Label.TextProperty, new Binding(nameof(player.Cunning)));
            SkitterPoints.SetBinding(Label.TextProperty, new Binding(nameof(player.Skitter)));
            GleamPoints.SetBinding(Label.TextProperty, new Binding(nameof(player.Gleam)));

            GritPoints.Text = "5";
        }

        private void OnCreateCharacterClicked(object sender, EventArgs e)
        {

        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

        }
        private void AddPower(object sender, EventArgs e)
        {
            if (Points > 0)
            {
                player.Power++;
                Points--;
                PointsLeftCounter.Text = Points.ToString();
            }
        }
        private void AddSneak(object sender, EventArgs e)
        {
            if (Points > 0)
            {
                player.Sneak++;
                Points--;
                PointsLeftCounter.Text = Points.ToString();
            }
        }
        private void AddGrit(object sender, EventArgs e)
        {
            if (Points > 0)
            {
                player.Grit++;
                Points--;
                PointsLeftCounter.Text = Points.ToString();
            }
        }
        private void AddMischief(object sender, EventArgs e)
        {
            if (Points > 0)
            {
                player.Mischief++;
                Points--;
                PointsLeftCounter.Text = Points.ToString();
            }
        }
        private void AddCunning(object sender, EventArgs e)
        {
            if (Points > 0)
            {
                player.Cunning++;
                Points--;
                PointsLeftCounter.Text = Points.ToString();
            }
        }
        private void AddSkitter(object sender, EventArgs e)
        {
            if (Points > 0)
            {
                player.Skitter++;
                Points--;
                PointsLeftCounter.Text = Points.ToString();
            }
        }
        private void AddGleam(object sender, EventArgs e)
        {
            if (Points > 0)
            {
                player.Gleam++;
                Points--;
                PointsLeftCounter.Text = Points.ToString();
            }
        }
    }

}
