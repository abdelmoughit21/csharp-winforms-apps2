namespace MyFirstWinFormsProject
{
    partial class frmCheckListBox
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnShowSelectedItems = new System.Windows.Forms.Button();
            this.btnCheckAllItems = new System.Windows.Forms.Button();
            this.btnUncheckAllItems = new System.Windows.Forms.Button();
            this.btnRemoveThirdItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(257, 49);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(270, 140);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(42, 252);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(141, 57);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnShowSelectedItems
            // 
            this.btnShowSelectedItems.Location = new System.Drawing.Point(229, 252);
            this.btnShowSelectedItems.Name = "btnShowSelectedItems";
            this.btnShowSelectedItems.Size = new System.Drawing.Size(141, 57);
            this.btnShowSelectedItems.TabIndex = 2;
            this.btnShowSelectedItems.Text = "Show Selected Items";
            this.btnShowSelectedItems.UseVisualStyleBackColor = true;
            this.btnShowSelectedItems.Click += new System.EventHandler(this.btnShowSelectedItems_Click);
            // 
            // btnCheckAllItems
            // 
            this.btnCheckAllItems.Location = new System.Drawing.Point(413, 252);
            this.btnCheckAllItems.Name = "btnCheckAllItems";
            this.btnCheckAllItems.Size = new System.Drawing.Size(141, 57);
            this.btnCheckAllItems.TabIndex = 3;
            this.btnCheckAllItems.Text = "Check All Items";
            this.btnCheckAllItems.UseVisualStyleBackColor = true;
            this.btnCheckAllItems.Click += new System.EventHandler(this.btnCheckAllItems_Click);
            // 
            // btnUncheckAllItems
            // 
            this.btnUncheckAllItems.Location = new System.Drawing.Point(612, 252);
            this.btnUncheckAllItems.Name = "btnUncheckAllItems";
            this.btnUncheckAllItems.Size = new System.Drawing.Size(141, 57);
            this.btnUncheckAllItems.TabIndex = 4;
            this.btnUncheckAllItems.Text = "Uncheck All Items";
            this.btnUncheckAllItems.UseVisualStyleBackColor = true;
            this.btnUncheckAllItems.Click += new System.EventHandler(this.btnUncheckAllItems_Click);
            // 
            // btnRemoveThirdItem
            // 
            this.btnRemoveThirdItem.Location = new System.Drawing.Point(293, 341);
            this.btnRemoveThirdItem.Name = "btnRemoveThirdItem";
            this.btnRemoveThirdItem.Size = new System.Drawing.Size(201, 57);
            this.btnRemoveThirdItem.TabIndex = 5;
            this.btnRemoveThirdItem.Text = "Remove Third Item";
            this.btnRemoveThirdItem.UseVisualStyleBackColor = true;
            this.btnRemoveThirdItem.Click += new System.EventHandler(this.btnRemoveThirdItem_Click);
            // 
            // frmCheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveThirdItem);
            this.Controls.Add(this.btnUncheckAllItems);
            this.Controls.Add(this.btnCheckAllItems);
            this.Controls.Add(this.btnShowSelectedItems);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "frmCheckListBox";
            this.Text = "frmCheckListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnShowSelectedItems;
        private System.Windows.Forms.Button btnCheckAllItems;
        private System.Windows.Forms.Button btnUncheckAllItems;
        private System.Windows.Forms.Button btnRemoveThirdItem;
    }
}