using Engine.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; private set; }

        public HealingPotion(ItemID id, string name, string pluralName, int amountToHeal)
            : base(id, name, pluralName)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
