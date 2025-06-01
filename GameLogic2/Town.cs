using GoblinMode.Character; 
using GoblinMode.Dialogue;
using GoblinMode.Item;
using GoblinMode.Combat;
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
            CharacterFactory<NonPlayableCharacter> enemyFactory = new EnemyFactory(diffuculty, new RandomWeaponFactory());

            for (int i = 0; i < numberToPopulate; i++)
            {
                enemies.Add(enemyFactory.CreateCharacter());
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

        public BattleFacade StartFight(NonPlayableCharacter selectedNPC)
        {
            BattleController controller = new BattleController(CharacterManager.Instance.GetPlayer(), selectedNPC);
            return new BattleFacade(controller);
        }

        public void GetHelp()
        {
            DialogueManager.Instance.StartDialogue(CharacterManager.Instance.GetCharacterByID(0));
        }
    }
}