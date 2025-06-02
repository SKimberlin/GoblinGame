using GoblinMode.Character;
using UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinMode.Interfaces;

namespace GoblinMode.Dialogue
{
    public class DialogueManager
    {
        private static DialogueManager instance;
        private IDialogueComponent currentResponse;
        private DialogueCharacter playerUI;
        private DialogueCharacter currentNPCUI;

        public static DialogueManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DialogueManager();
                }
                return instance;
            }
        }
        
        public void StartDialogue(NonPlayableCharacter npc)
        {
            currentResponse = npc.dialogue;
            playerUI = new DialogueCharacter();
            currentNPCUI = new DialogueCharacter();

            playerUI.Name = CharacterManager.Instance.GetPlayer().GetName();
            playerUI.PortraitPath = CharacterManager.Instance.GetPlayer().GetPortrait();

            currentNPCUI.Name = npc.GetName();
            currentNPCUI.PortraitPath = npc.GetPortrait();
        }

        public IDialogueComponent GetCurrentResponse()
        {
            return currentResponse;
        }

        public void SetNewResponse(string key)
        {
            currentResponse = currentResponse.GetChild(key);
        }

        public Dictionary<string, IDialogueComponent> GetCurrentOptions()
        {
            return currentResponse.GetOptions();
        }

        public DialogueCharacter GetPlayerUI()
        {
            return playerUI;
        }

        public DialogueCharacter GetCurrentNPCUI()
        {
            return currentNPCUI;
        }
    }
}