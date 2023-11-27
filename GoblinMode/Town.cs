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
        public int id;
        private static int lastAssignedId = 0;
        public string name;
        public Image townImage;
        public List<int> residentIDs;
        public Town() 
        {
            id = lastAssignedId++;
            residentIDs = new List<int>();
        }
    }
}
