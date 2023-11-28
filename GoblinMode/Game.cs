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
                Response response = new Response();
                response.responseText = "What town do you feel like starting at?";
                //response.dialogueOptions.Add("Bogmire's Hollow", );
                //response.dialogueOptions.Add("Rotbury", );
                //response.dialogueOptions.Add("Iron Chargate", );
                Response responseStart = new Response();
                responseStart.dialogueOptions = new Dictionary<string, Response>();
                responseStart.responseText = "Hey there youngin";
                responseStart.dialogueOptions.Add("Hi Wise Old Gob!", response);
                dialogue.dialogueStart = responseStart;

                CharacterManager.Instance.AddCharacter(npc);
            }
            
        }
    }
}
