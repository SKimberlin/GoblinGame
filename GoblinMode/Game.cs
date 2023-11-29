using GoblinMode.Character;
using GoblinMode.Dialogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode
{
    internal class Game
    {
        bool quit = false;
        public Game() 
        {
            InitializeGame();
            Application.Run(new TitleForm());
        }

        private void InitializeGame() 
        {
            
            {
                NonPlayableCharacter npc = new NonPlayableCharacter();
                npc.name = "Wise Old Gob";
                npc.portrait = Image.FromFile("assets/mogus.jpg");
                Dialogue.Dialogue dialogue = new Dialogue.Dialogue();
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
