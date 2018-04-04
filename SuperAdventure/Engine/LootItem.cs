using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LootItem
    {
        public Item details { get; set; }
        public int dropPercent { get; set; }
        public bool isDefaultItem { get; set; }

        public LootItem(Item details, int dropPercent, bool isDefaultItem)
        {
            this.details = details;
            this.dropPercent = dropPercent;
            this.isDefaultItem = isDefaultItem;
        }
    }
}
