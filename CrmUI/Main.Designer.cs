namespace CrmUI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductAppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.werehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WerehouseAppendToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryAppendToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.werehouseToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.currentToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductAppendToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // ProductAppendToolStripMenuItem
            // 
            this.ProductAppendToolStripMenuItem.Name = "ProductAppendToolStripMenuItem";
            this.ProductAppendToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProductAppendToolStripMenuItem.Text = "Append";
            this.ProductAppendToolStripMenuItem.Click += new System.EventHandler(this.ProductAppendToolStripMenuItem_Click);
            // 
            // werehouseToolStripMenuItem
            // 
            this.werehouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WerehouseAppendToolStripMenuItem1});
            this.werehouseToolStripMenuItem.Name = "werehouseToolStripMenuItem";
            this.werehouseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.werehouseToolStripMenuItem.Text = "Werehouse";
            this.werehouseToolStripMenuItem.Click += new System.EventHandler(this.werehouseToolStripMenuItem_Click);
            // 
            // WerehouseAppendToolStripMenuItem1
            // 
            this.WerehouseAppendToolStripMenuItem1.Name = "WerehouseAppendToolStripMenuItem1";
            this.WerehouseAppendToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.WerehouseAppendToolStripMenuItem1.Text = "Append";
            this.WerehouseAppendToolStripMenuItem1.Click += new System.EventHandler(this.WerehouseAppendToolStripMenuItem1_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryAppendToolStripMenuItem2});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // CategoryAppendToolStripMenuItem2
            // 
            this.CategoryAppendToolStripMenuItem2.Name = "CategoryAppendToolStripMenuItem2";
            this.CategoryAppendToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.CategoryAppendToolStripMenuItem2.Text = "Append";
            this.CategoryAppendToolStripMenuItem2.Click += new System.EventHandler(this.CategoryAppendToolStripMenuItem2_Click);
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentUpdateToolStripMenuItem});
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.currentToolStripMenuItem.Text = "Current";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
            // 
            // CurrentUpdateToolStripMenuItem
            // 
            this.CurrentUpdateToolStripMenuItem.Name = "CurrentUpdateToolStripMenuItem";
            this.CurrentUpdateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.CurrentUpdateToolStripMenuItem.Text = "Update";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 285);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem werehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductAppendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WerehouseAppendToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CategoryAppendToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem CurrentUpdateToolStripMenuItem;
    }
}

