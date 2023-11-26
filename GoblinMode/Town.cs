using GoblinMode.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode
{
    public class Town
    {
        public string name;
        public Image townImage;
        public List<NonPlayableCharacter> residents;
        public Town() 
        {
            residents = new List<NonPlayableCharacter>();
        }
    }
}
