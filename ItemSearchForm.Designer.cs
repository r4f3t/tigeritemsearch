namespace ItemSearchTiger
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
            this.SuspendLayout();
            // 
            // TXTGeneral
            // 
            this.TXTGeneral.BackColor = System.Drawing.SystemColors.Window;
            this.TXTGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTGeneral.Location = new System.Drawing.Point(117, 3);
            this.TXTGeneral.Name = "TXTGeneral";
            this.TXTGeneral.Size = new System.Drawing.Size(196, 20);
            this.TXTGeneral.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Aqua;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(5, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Genel Arama";
            // 
            // ItemSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TXTGeneral);
            this.Name = "ItemSearchForm";
            this.Text = "ItemSearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTGeneral;
        private System.Windows.Forms.TextBox textBox2;
    }
}