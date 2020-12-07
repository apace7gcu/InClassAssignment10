using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class ManageList : InventoryParent
    {
        //Create reference variable for inventory
        private List<InventoryObject> myInventory;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="itemNumberVal"></param>
        /// <param name="itemVal"></param>
        /// <param name="itemCostVal"></param>
        /// <param name="itemDescVal"></param>
        /// <param name="myInventoryVal"></param>
        public ManageList(int itemNumberVal, string itemVal,
            decimal itemCostVal, string itemDescVal, List<InventoryObject> myInventoryVal)
            : base(itemNumberVal, itemVal, itemCostVal, itemDescVal)
        {
            myInventory = myInventoryVal;
        }

        public List<InventoryObject> addToList()
        {
            //Add an Item to the list

            myInventory.Add(new InventoryObject(itemNumber, item, itemCost, itemDesc));

            return (myInventory);

           // myInventory.Add(new InventoryObject(1, "Shirt", 2.99m, "Shirt for a small person."));
        }
    }
}
