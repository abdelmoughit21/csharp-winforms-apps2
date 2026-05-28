namespace MyFirstWinFormsProject
{
    partial class frmImageListAndTreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageListAndTreeView));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ahmed");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ali");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Youssef");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Boys", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Karima");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Amal");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Hiba");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Girls", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Boy.png");
            this.imageList1.Images.SetKeyName(1, "Girl.png");
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(225, 41);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Ahmed";
            treeNode1.Text = "Ahmed";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "Ali";
            treeNode2.Text = "Ali";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "Youssef";
            treeNode3.Text = "Youssef";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Boys";
            treeNode4.Text = "Boys";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "Karima";
            treeNode5.Text = "Karima";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Amal";
            treeNode6.Text = "Amal";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Hiba";
            treeNode7.Text = "Hiba";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "Girls";
            treeNode8.Text = "Girls";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(330, 253);
            this.treeView1.TabIndex = 0;
            // 
            // frmImageListAndTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.treeView1);
            this.Name = "frmImageListAndTreeView";
            this.Text = "frmImageListAndTreeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
    }
}