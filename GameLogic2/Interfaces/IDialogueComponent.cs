using System.Collections.Generic;

namespace GoblinMode.Interfaces
{
    public interface IDialogueComponent
    {
        string GetText();
        Dictionary<string, IDialogueComponent> GetOptions();
        IDialogueComponent GetChild(string key);
    }
}