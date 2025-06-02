using GoblinMode.Character;
using GoblinMode.Dialogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinMode.Interfaces;

namespace GoblinMode
{
    public class Game
    {
        bool quit = false;
        public Game() 
        {
            InitializeGame();
            
        }

        private void InitializeGame() 
        {
            
            {
                NonPlayableCharacter npc = new NonPlayableCharacter();
                npc.SetName("Wise Old Gob");
                npc.SetPortrait("assets/mogus.jpg");

                DialogueComposite dialogueTree = new DialogueComposite("Whatchya need help with playa?");

                DialogueLeaf helpResponse = new DialogueLeaf("You can fight opponents, and rest to get health back");
                DialogueLeaf understandingResponse = new DialogueLeaf(":)");
                DialogueLeaf meanResponse = new DialogueLeaf("That is awfully rude of you.");

                DialogueComposite workTree = new DialogueComposite("Do you really need more?");
                workTree.AddOption("Guess not.", understandingResponse);
                workTree.AddOption("Of course stupid.", meanResponse);

                dialogueTree.AddOption("What am I meant to do!", helpResponse);
                dialogueTree.AddOption("Why isn't there more?", workTree);

                npc.dialogue = dialogueTree;

                CharacterManager.Instance.AddCharacter(npc);
            }
        }
    }
}
