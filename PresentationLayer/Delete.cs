using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace PresentationLayer
{
    public partial class Delete : Form
    {

        //Define Attrributes

        public int itemNumber { get; private set; }

        public string item { get; private set; }

        public decimal itemCost { get; private set; }

        public string itemDesc { get; private set; }

        List<InventoryObject> myInventory;

        public Delete(int itemNumberVal, string itemVal, decimal itemCostVal, 
            string itemDescVal, List<InventoryObject> myInventoryVal)
        {
            InitializeComponent();

            itemNumber = itemNumberVal;

            item = itemVal;

            itemCost = itemCostVal;

            itemDesc = itemDescVal;

            myInventory = myInventoryVal;

            //Show the inventory items in the label

            lblDelete.Text = string.Format("This is the inventory to delete: \n" +
                "Item Number: {0}\n Item Name: {1} \n Item Cost: ${2} \n Item Desc: {3}",
                itemNumber, item, itemCost, itemDesc);


        }
        /// <summary>
        /// Delete the selected inventory line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void bttnLabelDelete_Click(object sender, EventArgs e)
        {
            //Instantiate manage list and creat an object and pass all parameters to the constructor

            ManageList deleteItem = new ManageList(itemNumber, item, itemCost, itemDesc, myInventory);

            //Call the method that will actually remove the row

            myInventory = deleteItem.deleteFromList();

            this.Hide();

            //To get the form object, we first have to create an instance of the form
            //Override the constructor in the form

            InventoryDisplay frmInventory = new InventoryDisplay(myInventory);

            frmInventory.Show();

        }
    }
    
}

