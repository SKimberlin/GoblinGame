using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using GoblinMode.Interfaces;

namespace GoblinMode.Character
{
    public class NonPlayableCharacter : Character
    {
        private int id;
        private static int lastAssignedId = 0;
        public NonPlayableCharacter()
        {
            id = lastAssignedId++;
        }
        public int GetId()
        {
            return id;
        }
        public IDialogueComponent dialogue { get; set; }

    }
}
