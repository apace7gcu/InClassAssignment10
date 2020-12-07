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
    public partial class InventoryDisplay : Form
    {
        //Create the inventory reference variable

        List<InventoryObject> myInventory = new List<InventoryObject>();

        //Create an instance of the Datatable

        DataTable dt = new DataTable();

        public InventoryDisplay()
        {
            InitializeComponent();
        }

       /// <summary>
       /// Event handler to add inventory item
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void bttnAddItem_Click(object sender, EventArgs e)
        {

            //define variables

            int itemNumber = 0;
            decimal itemCost = 0;

            //-----------------------------------------
            //Verify Inputs
            //-------------------------------------------

            VerifyInputs testInvData = new VerifyInputs();

            itemNumber = testInvData.testItemNumber(txtItemNum.Text);

            if(itemNumber == 0)
            {
                showMessage("Item Number can only be numbers. Please try again...");
            }

            itemCost = testInvData.testItemCost(txtItemCost.Text);

            if (itemNumber == 0)
            {
                showMessage("Item Number can only be numbers. Please try again...");
            }

            //-----------------------------------------
            //Add Inventory Item to list
            //-------------------------------------------

            ManageList newInvItem = new ManageList(itemNumber, txtItemName.Text, itemCost, txtItemDesc.Text, myInventory);

            myInventory = newInvItem.addToList();

            ClearInputBoxes();

            //---------------------------------------
            //Update the datatable
            //--------------------------------------

            dgInventory.ColumnCount = 4;
            dgInventory.Columns[0].Name = "Item #";
            dgInventory.Columns[1].Name = "Item";
            dgInventory.Columns[2].Name = "Cost";
            dgInventory.Columns[3].Name = "Description";

            //Clear the table

            dgInventory.Rows.Clear();

            //Populate the table

            foreach (var item in myInventory)
            {
                dgInventory.Rows.Add(item.itemNumber, item.item, item.itemCost, item.itemDesc);
            }
        }

        /// <summary>
        /// Shows a message on the screen
        /// </summary>
        /// <param name="messageToShow"></param>
        private void showMessage(string messageToShow)
        {
            MessageBox.Show(messageToShow);
        }

        private void ClearInputBoxes()
        {
            txtItemNum.Text = "";
            txtItemName.Text = "";
            txtItemCost.Text = "";
            txtItemDesc.Text = "";
        }
    }
}
