using GoblinMode;
using GoblinMode.Character;

namespace GoblinModeMaui;

public partial class TownPage : ContentPage
{
    public TownPage()
    {
        InitializeComponent();
        Town.Instance.PopulateEnemies(5);
        UpdatePicker();
    }

    public void UpdatePicker()
    {
        var enemies = Town.Instance.GetEnemies();

        if (enemies != null)
        {
            EnemyPicker.ItemsSource = enemies;
            EnemyPicker.ItemDisplayBinding = new Binding("name");
        }
        else
        {
            EnemyPicker.ItemsSource = null;
        }
    }

    private async void Fight(object sender, EventArgs e)
    {
        if (EnemyPicker.SelectedItem is NonPlayableCharacter selectedEnemy)
        {
            Town.Instance.StartFight(selectedEnemy);
            App.Current.MainPage = new NavigationPage(new BattlePage(this));
        }
    }

    private void GetHelp(object sender, EventArgs e)
    {
        Town.Instance.GetHelp();
        App.Current.MainPage = new NavigationPage(new DialoguePage(this));
    }
    private void Rest(object sender, EventArgs e)
    {
        Town.Instance.Rest();
    }
}