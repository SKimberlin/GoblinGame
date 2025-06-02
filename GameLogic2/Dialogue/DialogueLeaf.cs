using System.Collections.Generic;
using GoblinMode.Interfaces;

namespace GoblinMode.Dialogue
{
    public class DialogueLeaf : IDialogueComponent
    {
        private string text;

        public DialogueLeaf(string text)
        {
            this.text = text;
        }

        public string GetText()
        {
            return text;
        }

        public Dictionary<string, IDialogueComponent> GetOptions()
        {
            return new Dictionary<string, IDialogueComponent>();
        }

        public IDialogueComponent GetChild(string key)
        {
            return null;
        }
    }
}