using System.Collections.Generic;
using GoblinMode.Interfaces;

namespace GoblinMode.Dialogue
{
    public class DialogueComposite : IDialogueComponent
    {
        private string text;
        private Dictionary<string, IDialogueComponent> options;

        public DialogueComposite(string text)
        {
            this.text = text;
            options = new Dictionary<string, IDialogueComponent>();
        }

        public string GetText()
        {
            return text;
        }

        public Dictionary<string, IDialogueComponent> GetOptions()
        {
            return options;
        }

        public IDialogueComponent GetChild(string key)
        {
            return options.ContainsKey(key) ? options[key] : null;
        }

        public void AddOption(string key, IDialogueComponent component)
        {
            options.Add(key, component);
        }
    }
}