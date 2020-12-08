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

            //Prepopulate the pull down combo box
            cboItem.Items.Add("1");
            cboItem.Items.Add("2");
            cboItem.Items.Add("3");
            cboItem.Items.Add("4");
            cboItem.Items.Add("5");

        }

        public InventoryDisplay(List<InventoryObject> myInventory)
        {
            InitializeComponent();

            //Update the display

            populateGrid(myInventory);
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pre populate item number box

            txtItemNum.Text = cboItem.SelectedItem.ToString();
            txtItemName.Text = string.Format("Item {0}", cboItem.SelectedItem.ToString());


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

            dgInventory.Columns[0].ValueType = typeof(int);
            dgInventory.Columns[1].ValueType = typeof(string);
            dgInventory.Columns[2].ValueType = typeof(decimal);
            dgInventory.Columns[3].ValueType = typeof(string);



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

        /// <summary>
        /// Delete an Inventory Iten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnDeleteItem_Click(object sender, EventArgs e)
        {
            //We first need to determine which row is selected 
            //Represents a collection of DataGridView objects that are selected.
            DataGridViewSelectedRowCollection rows = dgInventory.SelectedRows;

            //Needs error checking to ensure a row is actually selected.
            var anyRowsSelected = rows[0].Index;

            //From the rows object get all the values from the selected row
            int itemNumVal = (int)rows[0].Cells["Item #"].Value;
            string itemVal = (string)rows[0].Cells["Item"].Value;
            decimal itemCostVal = (decimal)rows[0].Cells["Cost"].Value;
            string itemDescVal = (string)rows[0].Cells["Description"].Value;

            this.Hide();

            Delete frmDelete = new Delete(itemNumVal, itemVal, itemCostVal, itemDescVal, myInventory);

            frmDelete.Show();
        }
        /// <summary>
        /// Populate the dataGridView
        /// </summary>
        /// <param name="myInventory"></param>
        private void populateGrid(List<InventoryObject> myInventory)
        {
            //---------------------------------------
            //Update the datatable
            //--------------------------------------

            dgInventory.ColumnCount = 4;
            dgInventory.Columns[0].Name = "Item #";
            dgInventory.Columns[1].Name = "Item";
            dgInventory.Columns[2].Name = "Cost";
            dgInventory.Columns[3].Name = "Description";

            dgInventory.Columns[0].ValueType = typeof(int);
            dgInventory.Columns[1].ValueType = typeof(string);
            dgInventory.Columns[2].ValueType = typeof(decimal);
            dgInventory.Columns[3].ValueType = typeof(string);



            //Clear the table

            dgInventory.Rows.Clear();

            //Populate the table

            foreach (var item in myInventory)
            {
                dgInventory.Rows.Add(item.itemNumber, item.item, item.itemCost, item.itemDesc);
            }
        }
    }
}
