﻿using Engine.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class InventoryItem
    {
        public Item details { get; set; }
        public int quantity { get; set; }

        public InventoryItem(Item details, int quantity)
        {
            this.details = details;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return details.Name + ": " + quantity;
        }
    }
}
