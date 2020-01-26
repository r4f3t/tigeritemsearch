namespace ItemSearchTiger
{
    partial class ItemB2BExpReport
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
            this.BtnGetData = new System.Windows.Forms.Button();
            this.BtnExportToExcel = new System.Windows.Forms.Button();
            this.GridItems = new System.Windows.Forms.DataGridView();
            this.CMBSpecode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetData
            // 
            this.BtnGetData.Location = new System.Drawing.Point(164, -1);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(111, 35);
            this.BtnGetData.TabIndex = 0;
            this.BtnGetData.Text = "Ürünleri Getir";
            this.BtnGetData.UseVisualStyleBackColor = true;
            this.BtnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // BtnExportToExcel
            // 
            this.BtnExportToExcel.Location = new System.Drawing.Point(1102, -1);
            this.BtnExportToExcel.Name = "BtnExportToExcel";
            this.BtnExportToExcel.Size = new System.Drawing.Size(111, 35);
            this.BtnExportToExcel.TabIndex = 0;
            this.BtnExportToExcel.Text = "Excel";
            this.BtnExportToExcel.UseVisualStyleBackColor = true;
            this.BtnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcel_Click);
            // 
            // GridItems
            // 
            this.GridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItems.Location = new System.Drawing.Point(0, 31);
            this.GridItems.Name = "GridItems";
            this.GridItems.RowTemplate.Height = 24;
            this.GridItems.Size = new System.Drawing.Size(1213, 722);
            this.GridItems.TabIndex = 2;
            // 
            // CMBSpecode
            // 
            this.CMBSpecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CMBSpecode.FormattingEnabled = true;
            this.CMBSpecode.Location = new System.Drawing.Point(0, 1);
            this.CMBSpecode.Name = "CMBSpecode";
            this.CMBSpecode.Size = new System.Drawing.Size(164, 30);
            this.CMBSpecode.TabIndex = 3;
            // 
            // ItemB2BExpReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 753);
            this.Controls.Add(this.CMBSpecode);
            this.Controls.Add(this.GridItems);
            this.Controls.Add(this.BtnExportToExcel);
            this.Controls.Add(this.BtnGetData);
            this.Name = "ItemB2BExpReport";
            this.Text = "Ürün Açıklama Durumları";
            this.Load += new System.EventHandler(this.ItemB2BExpReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.Button BtnExportToExcel;
        private System.Windows.Forms.DataGridView GridItems;
        private System.Windows.Forms.ComboBox CMBSpecode;
    }
}