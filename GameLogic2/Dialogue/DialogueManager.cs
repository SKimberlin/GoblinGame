using GoblinMode.Character;
using UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.Dialogue
{
    public class DialogueManager
    {
        private DialogueCharacter playerUI;
        private DialogueCharacter currentNPCUI;
        private NonPlayableCharacter currentNPC;
        private Response currentResponse = new Response();
        private Dialogue dialogue = new Dialogue();
        private static DialogueManager instance;
        
        public void StartDialogue(NonPlayableCharacter npc)
        {
            currentNPC = npc;
            this.dialogue = currentNPC.dialogue;
            currentResponse = this.dialogue.dialogueStart;
            playerUI = new DialogueCharacter();
            currentNPCUI = new DialogueCharacter();

            playerUI.Name = CharacterManager.Instance.GetPlayer().GetName();
            playerUI.PortraitPath = CharacterManager.Instance.GetPlayer().GetPortrait();

            currentNPCUI.Name = npc.GetName();
            currentNPCUI.PortraitPath = npc.GetPortrait();
        }
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
        public Response GetCurrentResponse() { return currentResponse; }
        public void SetNewResponse(string stringKey) { currentResponse = currentResponse.dialogueOptions[stringKey]; }
        public UI.DialogueCharacter GetPlayerUI() { return playerUI; }
        public UI.DialogueCharacter GetCurrentNPCUI() { return currentNPCUI; }
    }
}
