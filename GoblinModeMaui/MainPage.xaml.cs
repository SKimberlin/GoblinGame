using GoblinMode.Character;
using GoblinMode.Dialogue;

namespace GoblinModeMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();

        }

        private void OnNewGameClicked(object sender, EventArgs e)
        {
            InitializeGame();
            string newDirectory = AppContext.BaseDirectory + "/../../../../../../GameLogic2";
            Directory.SetCurrentDirectory(newDirectory);
            string currentDirectory = Directory.GetCurrentDirectory();
            App.Current.MainPage = new NavigationPage(new CharacterCreatePage());
        }
        private void InitializeGame()
        {

            {
                NonPlayableCharacter npc = new NonPlayableCharacter();
                npc.SetName("Wise Old Gob");
                npc.SetPortrait("assets/mogus.jpg");
                Dialogue dialogue = new Dialogue();
                Response helpResponse = new Response();
                helpResponse.responseText = "You can fight opponenents, and rest to get health back";
                Response workResponse = new Response();
                Response understandingResponse = new Response();
                Response meanResponse = new Response();
                understandingResponse.responseText = ":)";
                meanResponse.responseText = "That is awfully rude of you.";
                workResponse.responseText = "Do you really need more?";
                workResponse.dialogueOptions = new Dictionary<string, Response>();
                workResponse.dialogueOptions.Add("Guess not.", understandingResponse);
                workResponse.dialogueOptions.Add("Of course stupid.", meanResponse);
                Response lonelyResponse = new Response();
                lonelyResponse.responseText = "I can't help you with that!";
                Response responseStart = new Response();
                responseStart.dialogueOptions = new Dictionary<string, Response>();
                responseStart.responseText = "Whatchya need help with playa?";
                responseStart.dialogueOptions.Add("What am I meant to do!", helpResponse);
                responseStart.dialogueOptions.Add("Why isn't there more?", workResponse);
                responseStart.dialogueOptions.Add("I feel lonely :(", lonelyResponse);
                dialogue.dialogueStart = responseStart;
                npc.dialogue = dialogue;

                CharacterManager.Instance.AddCharacter(npc);
            }
        }
    }

}
