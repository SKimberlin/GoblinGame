using GoblinMode.Character;
using GoblinMode.Dialogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode
{
    public class Town
    {
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

        public void Rest()
        {
            CharacterManager.Instance.GetPlayer().SetHealthToMax();
        }

        public void StartFight(NonPlayableCharacter selectedNPC)
        {
            BattleController.Instance.SetBattle(selectedNPC);
        }
        public void GetHelp()
        {
            DialogueManager.Instance.StartDialogue(CharacterManager.Instance.GetCharacterByID(0));
        }
    }
}