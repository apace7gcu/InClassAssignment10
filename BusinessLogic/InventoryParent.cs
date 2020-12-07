using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class InventoryParent
    {
        //Define attributes

        public int itemNumber { get; private set; }

        public string item { get; private set; }

        public decimal itemCost {get; private set;}

        public string itemDesc { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="itemNumberVal"></param>
        /// <param name="itemVal"></param>
        /// <param name="itemCostVal"></param>
        /// <param name="itemDescVal"></param>
        public InventoryParent(int itemNumberVal, string itemVal, decimal itemCostVal, string itemDescVal)
        {
            this.itemNumber = itemNumberVal;
            this.item = itemVal;
            this.itemCost = itemCostVal;
            this.itemDesc = itemDescVal;
        }
    }
}
