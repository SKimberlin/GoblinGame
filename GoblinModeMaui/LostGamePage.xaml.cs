namespace GoblinModeMaui;

public partial class LostGamePage : ContentPage
{
	public LostGamePage()
	{
		InitializeComponent();
	}

    private void NewGame(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new CharacterCreatePage());
    }
    private void QuitGame(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}