using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine
{
    public class Inventory : BindingList<InventoryItem>
    {
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach(var a in this)
            {
                result.Append(a.ToString());
                result.Append("\n");
            }
            return result.ToString();
        }
    }
}