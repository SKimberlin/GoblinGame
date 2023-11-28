using GoblinMode.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.Dialogue
{
    internal class DialogueManager
    {
        public DialogueManager(NonPlayableCharacter npc)
        {
            DialogueForm form = new DialogueForm(npc);
        }
    }
}
