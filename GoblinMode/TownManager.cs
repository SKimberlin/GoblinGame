using GoblinMode.Character;
using GoblinMode.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode
{
    internal class TownManager
    {
        private static TownManager instance;
        private List<Town> towns = new List<Town>();
        public TownManager()
        {

        }
        public static TownManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TownManager();
                }
                return instance;
            }
        }
        public void AddTown(Town town)
        {
            towns.Add(town);
        }
        public Town GetTownByID(int id) 
        {
            foreach (Town town in towns)
            {
                if (town.id == id)
                {
                    return town;
                }
            }
            return null;
        }
        public Town GetTownByName(string name)
        {
            foreach (Town town in towns)
            {
                if (town.name == name)
                {
                    return town;
                }
            }
            return null;
        }

        public List<Town> GetTowns() 
        {
            return towns;
        }

    }
}
