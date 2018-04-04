using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Weapon : Item
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage) :
            base(id, name, namePlural)
        {
            MinDamage = minimumDamage;
            MaxDamage = maximumDamage;
        }
    }
}
