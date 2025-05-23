using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.Item
{
    public class Weapon : Item
    {
        
        private float damage;

        public void SetDamage(float damage) { this.damage = damage; }
        public float GetDamage() { return this.damage; }
    }
}
