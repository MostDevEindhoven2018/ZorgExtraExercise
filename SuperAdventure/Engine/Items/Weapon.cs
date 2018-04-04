using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    class Weapon : Item
    {
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }

        public Weapon(ItemID id, string name, string pluralName, int minimumDamage = 1, int maximumDamage = 5) :
            base(id, name, pluralName)
        {
            MinDamage = minimumDamage;
            MaxDamage = maximumDamage;
        }
    }
}
