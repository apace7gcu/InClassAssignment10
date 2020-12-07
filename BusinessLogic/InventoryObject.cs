using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class InventoryObject : InventoryParent
    {
        public InventoryObject(int itemNumberVal, string itemVal,
            decimal itemCostVal, string itemDescVal) : base(itemNumberVal,
                itemVal, itemCostVal, itemDescVal)
        {


        }

    }
}
