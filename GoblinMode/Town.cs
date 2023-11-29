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
        private TownForm form = new TownForm();
        private static Town instance;
        private List<NonPlayableCharacter> enemies = new List<NonPlayableCharacter>();
        public event EventHandler EnemiesListChanged;
        private void OnEnemiesListChanged()
        {
            EnemiesListChanged?.Invoke(this, EventArgs.Empty);
        }
        public static Town Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Town();
                }
                return instance;
            }
        }

        public void OpenTownForm()
        {
            form.Show();
        }
        public void CloseTownForm()
        {
            form.Hide();
        }
        public List<NonPlayableCharacter> GetEnemies() { return enemies; }
        public void PopulateEnemies(int numberToPopulate)
        {
            enemies.Clear();
            float diffuculty = CharacterManager.Instance.GetPlayer().GetLevel() + 2;
            
            for (int i = 0; i < numberToPopulate; i++)
            {
                enemies.Add(Random.GetRandomNPC(diffuculty));
            }
            OnEnemiesListChanged();
        }
        public void KillEnemy(NonPlayableCharacter enemy)
        {
            foreach (var character in enemies) 
            {
                if (character == enemy)
                {
                    enemies.Remove(character);
                    OnEnemiesListChanged();
                    break;
                }
            }
        }
    }
}
