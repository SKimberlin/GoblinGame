using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using GoblinMode.Item;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GoblinMode.Character
{
    public class Player : Character
    {
        
        private int level = 1;
        private float exp;
        private float money;

        public void LevelUp()
        {
            
        }

        public int GetLevel() { return level; }

    }
}
