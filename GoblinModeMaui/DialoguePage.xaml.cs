using GoblinMode.Character;
using GoblinMode.Dialogue;
using UI;

namespace GoblinModeMaui;


public partial class DialoguePage : ContentPage
{
    private DialogueCharacter playerUI;
    private DialogueCharacter currentNPCUI;
    ContentPage prevPage;
	public DialoguePage(ContentPage prevPage)
	{
		InitializeComponent();
        playerUI = DialogueManager.Instance.GetPlayerUI();
        currentNPCUI = DialogueManager.Instance.GetCurrentNPCUI();
        this.prevPage = prevPage;

        PlayerNameBox.Text = playerUI.Name;
        NPCNameBox.Text = currentNPCUI.Name;

        UpdateUI();
    }
    private void SubmitResponse(object sender, EventArgs e)
    {
        if (DialoguePicker.SelectedItem == null) return;

        if (DialoguePicker.SelectedItem is string selectedOption)
        {
            DialogueManager.Instance.SetNewResponse(selectedOption);
            UpdateUI();
        }
    }
    private void UpdateUI()
    {

        if (DialogueManager.Instance.GetCurrentResponse() == null) return;
        DialogueBox.Text = DialogueManager.Instance.GetCurrentResponse().responseText;
        DialoguePicker.Items.Clear();

        if (DialogueManager.Instance.GetCurrentResponse().dialogueOptions != null)
        {
            foreach (var option in DialogueManager.Instance.GetCurrentResponse().dialogueOptions.Keys)
            {
                DialoguePicker.Items.Add(option);
            }
        }

    }
    private void LeaveDialogue(object sender, EventArgs e)
	{
        App.Current.MainPage = new NavigationPage(prevPage);
    }
}