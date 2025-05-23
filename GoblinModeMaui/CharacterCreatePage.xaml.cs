using GoblinMode.Character;
using GoblinMode.Item;

namespace GoblinModeMaui
{
    public partial class CharacterCreatePage : ContentPage
    {
        
        UI.Character player;
        public CharacterCreatePage()
        {
            InitializeComponent();
            
            player = new UI.Character();
            BindingContext = player;

        }

        private void OnCreateCharacterClicked(object sender, EventArgs e)
        {
            if (player.Points != 0) return;
            if (String.IsNullOrEmpty(NameBox.Text)) return;

            Player gamePlayer = new Player()
            {
                power = player.Power,
                sneak = player.Sneak,
                grit = player.Grit,
                mischief = player.Mischief,
                cunning = player.Cunning,
                skitter = player.Skitter,
                gleam = player.Gleam

            };

            gamePlayer.SetName(NameBox.Text);
            Weapon weapon = new Weapon();
            weapon.SetDamage(2.5f);
            weapon.SetName("Brawling Fists");
            weapon.SetRemoveable(false);
            gamePlayer.setCurrentWeapon(weapon);
            gamePlayer.SetDerived();
            CharacterManager.Instance.SetPlayer(gamePlayer);

            App.Current.MainPage = new NavigationPage(new TownPage());

        }
        private void AddPower(object sender, EventArgs e)
        {
            if (player.Points > 0)
            {
                player.Power++;
                player.Points--;
            }
        }
        private void AddSneak(object sender, EventArgs e)
        {
            if (player.Points > 0)
            {
                player.Sneak++;
                player.Points--;
            }
        }
        private void AddGrit(object sender, EventArgs e)
        {
            if (player.Points > 0)
            {
                player.Grit++;
                player.Points--;
            }
        }
        private void AddMischief(object sender, EventArgs e)
        {
            if (player.Points > 0)
            {
                player.Mischief++;
                player.Points--;
            }
        }
        private void AddCunning(object sender, EventArgs e)
        {
            if (player.Points > 0)
            {
                player.Cunning++;
                player.Points--;
            }
        }
        private void AddSkitter(object sender, EventArgs e)
        {
            if (player.Points > 0)
            {
                player.Skitter++;
                player.Points--;
            }
        }
        private void AddGleam(object sender, EventArgs e)
        {
            if (player.Points > 0)
            {
                player.Gleam++;
                player.Points--;
            }
        }
        private void RemovePower(object sender, EventArgs e)
        {
            if (player.Power > 0 && player.Points < player.GetMaxPoints())
            {
                player.Power--;
                player.Points++;
            }
        }
        private void RemoveSneak(object sender, EventArgs e)
        {
            if (player.Sneak > 0 && player.Points < player.GetMaxPoints())
            {
                player.Sneak--;
                player.Points++;
            }
        }
        private void RemoveGrit(object sender, EventArgs e)
        {
            if (player.Grit > 0 && player.Points < player.GetMaxPoints())
            {
                player.Grit--;
                player.Points++;
            }
        }
        private void RemoveMischief(object sender, EventArgs e)
        {
            if (player.Mischief > 0 && player.Points < player.GetMaxPoints())
            {
                player.Mischief--;
                player.Points++;
            }
        }
        private void RemoveCunning(object sender, EventArgs e)
        {
            if (player.Cunning > 0 && player.Points < player.GetMaxPoints())
            {
                player.Cunning--;
                player.Points++;
            }
        }
        private void RemoveSkitter(object sender, EventArgs e)
        {
            if (player.Skitter > 0 && player.Points < player.GetMaxPoints())
            {
                player.Skitter--;
                player.Points++;
            }
        }
        private void RemoveGleam(object sender, EventArgs e)
        {
            if (player.Gleam > 0 && player.Points < player.GetMaxPoints())
            {
                player.Gleam--;
                player.Points++;
            }
        }
    }

}
