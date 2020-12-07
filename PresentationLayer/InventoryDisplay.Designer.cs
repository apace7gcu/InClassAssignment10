namespace PresentationLayer
{
    partial class InventoryDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtItemNum = new System.Windows.Forms.TextBox();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.txtItemCost = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnAddItem = new System.Windows.Forms.Button();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemNum
            // 
            this.txtItemNum.Location = new System.Drawing.Point(622, 174);
            this.txtItemNum.Name = "txtItemNum";
            this.txtItemNum.Size = new System.Drawing.Size(100, 20);
            this.txtItemNum.TabIndex = 0;
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Location = new System.Drawing.Point(622, 353);
            this.txtItemDesc.Multiline = true;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(152, 77);
            this.txtItemDesc.TabIndex = 1;
            // 
            // txtItemCost
            // 
            this.txtItemCost.Location = new System.Drawing.Point(622, 291);
            this.txtItemCost.Name = "txtItemCost";
            this.txtItemCost.Size = new System.Drawing.Size(100, 20);
            this.txtItemCost.TabIndex = 2;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(622, 233);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item Desc:";
            // 
            // bttnAddItem
            // 
            this.bttnAddItem.Location = new System.Drawing.Point(640, 73);
            this.bttnAddItem.Name = "bttnAddItem";
            this.bttnAddItem.Size = new System.Drawing.Size(134, 44);
            this.bttnAddItem.TabIndex = 8;
            this.bttnAddItem.Text = "Add Inventory Item";
            this.bttnAddItem.UseVisualStyleBackColor = true;
            this.bttnAddItem.Click += new System.EventHandler(this.bttnAddItem_Click);
            // 
            // dgInventory
            // 
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventory.Location = new System.Drawing.Point(12, 36);
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.Size = new System.Drawing.Size(503, 402);
            this.dgInventory.TabIndex = 9;
            // 
            // InventoryDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgInventory);
            this.Controls.Add(this.bttnAddItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemCost);
            this.Controls.Add(this.txtItemDesc);
            this.Controls.Add(this.txtItemNum);
            this.Name = "InventoryDisplay";
            this.Text = "InventoryDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemNum;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.TextBox txtItemCost;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnAddItem;
        private System.Windows.Forms.DataGridView dgInventory;
    }
}

