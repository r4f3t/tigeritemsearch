﻿namespace ItemSearchTiger
{
    partial class ItemSearchForm
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
            this.TXTGeneral = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LBItems = new System.Windows.Forms.ListBox();
            this.CMBDatabases = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TXTGeneral
            // 
            this.TXTGeneral.BackColor = System.Drawing.SystemColors.Window;
            this.TXTGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTGeneral.Location = new System.Drawing.Point(156, 6);
            this.TXTGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.TXTGeneral.Name = "TXTGeneral";
            this.TXTGeneral.Size = new System.Drawing.Size(260, 26);
            this.TXTGeneral.TabIndex = 0;
            this.TXTGeneral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTGeneral_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(7, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(149, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Genel Arama";
            // 
            // LBItems
            // 
            this.LBItems.BackColor = System.Drawing.Color.Black;
            this.LBItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LBItems.FormattingEnabled = true;
            this.LBItems.ItemHeight = 29;
            this.LBItems.Location = new System.Drawing.Point(7, 33);
            this.LBItems.Name = "LBItems";
            this.LBItems.Size = new System.Drawing.Size(623, 497);
            this.LBItems.TabIndex = 1;
            // 
            // CMBDatabases
            // 
            this.CMBDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBDatabases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMBDatabases.FormattingEnabled = true;
            this.CMBDatabases.Items.AddRange(new object[] {
            "Tiger",
            "TigerStr"});
            this.CMBDatabases.Location = new System.Drawing.Point(417, 7);
            this.CMBDatabases.Name = "CMBDatabases";
            this.CMBDatabases.Size = new System.Drawing.Size(213, 24);
            this.CMBDatabases.TabIndex = 1;
            // 
            // ItemSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(642, 554);
            this.Controls.Add(this.CMBDatabases);
            this.Controls.Add(this.LBItems);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TXTGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemSearchForm";
            this.Text = "Tiger Ürün Kartı Arama Ekranı";
            this.Load += new System.EventHandler(this.ItemSearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTGeneral;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox LBItems;
        private System.Windows.Forms.ComboBox CMBDatabases;
    }
}