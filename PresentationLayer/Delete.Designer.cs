namespace PresentationLayer
{
    partial class Delete
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
            this.bttnLabelDelete = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnLabelDelete
            // 
            this.bttnLabelDelete.Location = new System.Drawing.Point(317, 80);
            this.bttnLabelDelete.Name = "bttnLabelDelete";
            this.bttnLabelDelete.Size = new System.Drawing.Size(173, 50);
            this.bttnLabelDelete.TabIndex = 0;
            this.bttnLabelDelete.Text = "Are you sure you want to delete?";
            this.bttnLabelDelete.UseVisualStyleBackColor = true;
            this.bttnLabelDelete.Click += new System.EventHandler(this.bttnLabelDelete_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(314, 196);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(15, 13);
            this.lblDelete.TabIndex = 1;
            this.lblDelete.Text = "w";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.bttnLabelDelete);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnLabelDelete;
        private System.Windows.Forms.Label lblDelete;
    }
}