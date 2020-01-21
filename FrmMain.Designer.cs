namespace ItemSearchTiger
{
    partial class FrmMain
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
            this.ürünAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünAçıklamaExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tigerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünKartıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünAraToolStripMenuItem,
            this.ürünAçıklamaExcelToolStripMenuItem,
            this.tigerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünAraToolStripMenuItem
            // 
            this.ürünAraToolStripMenuItem.Name = "ürünAraToolStripMenuItem";
            this.ürünAraToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.ürünAraToolStripMenuItem.Text = "Ürün Ara";
            this.ürünAraToolStripMenuItem.Click += new System.EventHandler(this.ürünAraToolStripMenuItem_Click);
            // 
            // ürünAçıklamaExcelToolStripMenuItem
            // 
            this.ürünAçıklamaExcelToolStripMenuItem.Name = "ürünAçıklamaExcelToolStripMenuItem";
            this.ürünAçıklamaExcelToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.ürünAçıklamaExcelToolStripMenuItem.Text = "Ürün Açıklama Excel";
            this.ürünAçıklamaExcelToolStripMenuItem.Click += new System.EventHandler(this.ürünAçıklamaExcelToolStripMenuItem_Click);
            // 
            // tigerToolStripMenuItem
            // 
            this.tigerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünKartıGüncelleToolStripMenuItem});
            this.tigerToolStripMenuItem.Name = "tigerToolStripMenuItem";
            this.tigerToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.tigerToolStripMenuItem.Text = "Tiger";
            // 
            // ürünKartıGüncelleToolStripMenuItem
            // 
            this.ürünKartıGüncelleToolStripMenuItem.Name = "ürünKartıGüncelleToolStripMenuItem";
            this.ürünKartıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ürünKartıGüncelleToolStripMenuItem.Text = "Ürün Kartı Güncelle";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 617);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünAçıklamaExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tigerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünKartıGüncelleToolStripMenuItem;
    }
}