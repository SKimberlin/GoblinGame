using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace GoblinMode.Character
{
    public class NonPlayableCharacter : Character
    {
        public int id;
        private static int lastAssignedId = 0;
        public NonPlayableCharacter()
        {
            id = lastAssignedId++;
        }
        short PlayerStanding;
        public Dialogue.Dialogue dialogue { get; set; }

    }
}
