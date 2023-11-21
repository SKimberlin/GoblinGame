using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.Character
{
    public class NonPlayableCharacter : Character
    {
        short PlayerStanding;
        public Dialogue.Dialogue dialogue { get; set; }

        public override bool Read(string filename)
        {
            base.Read(filename);
            

            return true;
        }
    }
}
