using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.Item
{
    public class Weapon : Item
    {
        enum WeaponType
        {
            Sword,
            Dagger,
            Bow,
            Staff,
            Axe,
            Mace,
            Shield
        }

        WeaponType type { get; set; }
        public float damage;
        public Weapon(int type) { this.type = (WeaponType)type; }

    }
}
