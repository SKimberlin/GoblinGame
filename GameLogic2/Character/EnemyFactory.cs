using GoblinMode.Item;
namespace GoblinMode.Character
{
    public class EnemyFactory : CharacterFactory<NonPlayableCharacter>
    {
        private float difficulty;
        private static System.Random random = new System.Random();
        private RandomWeaponFactory randomWeaponFactory;
        public EnemyFactory(float difficulty, RandomWeaponFactory randomWeaponFactory)
        {
            this.difficulty = difficulty;
            this.randomWeaponFactory = randomWeaponFactory;
        }
        public override NonPlayableCharacter CreateCharacter()
        {
            NonPlayableCharacter enemy = new NonPlayableCharacter();

            string[] names = { "Angry Goober", "Hateful Goober", "Wacky Goober", "Sassy Goober" };
            string[] portraits = { "assets/GoblinMale.jpg", "assets/GoblinFemale.jpg" };

            enemy.SetName(names[random.Next(names.Length)]);
            enemy.SetPortrait(portraits[random.Next(portraits.Length)]);

            enemy.power = (int)(difficulty * random.NextDouble());
            enemy.sneak = (int)(difficulty * random.NextDouble());
            enemy.grit = (int)(difficulty * random.NextDouble());
            enemy.mischief = (int)(difficulty * random.NextDouble());
            enemy.cunning = (int)(difficulty * random.NextDouble());
            enemy.skitter = (int)(difficulty * random.NextDouble());
            enemy.gleam = (int)(difficulty * random.NextDouble());

            enemy.SetDerived();
            enemy.setCurrentWeapon(randomWeaponFactory.CreateItem());

            return enemy;
        }
    }
}
