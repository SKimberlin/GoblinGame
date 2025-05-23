using GoblinMode;
using UI;

namespace GoblinModeMaui;
public partial class BattlePage : ContentPage
{
    private Combatant currentNPCUI;
    private Combatant playerUI;
    ContentPage prevPage;
    public BattlePage(ContentPage prevPage)
	{
		InitializeComponent();
        playerUI = BattleController.Instance.GetPlayerUI();
        currentNPCUI = BattleController.Instance.GetCurrentNPCUI();

        PlayerNameBox.Text = playerUI.Name;
        NPCNameBox.Text = currentNPCUI.Name;

        UpdateHealthLabels();
    }
    private void UpdateHealthLabels()
    {
        PlayerCurrentHealth.Text = $"{playerUI.CurrentHealth}";
        PlayerMaxHealth.Text = $"{playerUI.MaxHealth}";

        NPCCurrentHealth.Text = $"{currentNPCUI.CurrentHealth}";
        NPCMaxHealth.Text = $"{currentNPCUI.MaxHealth}";
    }

    private void Attack(object sender, EventArgs e)
    {
        BattleController.Instance.Attack();
        BattleController.Instance.NPCTurn();
        UpdateHealthLabels();
        WinLoss();
    }

    private void Run(object sender, EventArgs e)
    {
        if (BattleController.Instance.Run()) App.Current.MainPage = new NavigationPage(new TownPage());
        BattleController.Instance.NPCTurn();
        UpdateHealthLabels();
        WinLoss();
    }

    private void Block(object sender, EventArgs e)
    {
        BattleController.Instance.Block();
        BattleController.Instance.NPCTurn();
        UpdateHealthLabels();
        WinLoss();
    }

    private void WinLoss()
    {
        if (BattleController.Instance.Win())
        {
            App.Current.MainPage = new NavigationPage(new TownPage());
        }
        if (BattleController.Instance.Loss())
        {
            App.Current.MainPage = new NavigationPage(new LostGamePage());
        }
    }
}