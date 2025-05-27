using GoblinMode.Character;
namespace GoblinMode.Item
{
    public class RandomWeaponFactory : ItemFactory<Weapon>
    {
        private static System.Random random = new System.Random();
        public override Weapon CreateItem()
        {
            Weapon item = new Weapon();

            string[] prefixes = {
                "GODS ONLY", "Moss covered", "Fierce", "Enchanted",
                "Ancient", "Mysterious", "Cursed", "Radiant", "Shadowy"
            };

            string[] types = { " Sword", " Spear", " Axe" };

            string name = prefixes[random.Next(prefixes.Length)] + types[random.Next(types.Length)];

            item.SetWeight((float)random.NextDouble() * 10);
            item.SetWorth((float)random.NextDouble() * 100);
            item.SetDamage((float)random.NextDouble() * 5 * (1 + (0.1f * CharacterManager.Instance.GetPlayer().GetLevel())));

            return item;
        }
    }
}
