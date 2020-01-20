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
            this.PBGetItems = new System.Windows.Forms.ProgressBar();
            this.GridItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetData
            // 
            this.BtnGetData.Location = new System.Drawing.Point(0, -1);
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
            // PBGetItems
            // 
            this.PBGetItems.Location = new System.Drawing.Point(110, -1);
            this.PBGetItems.Name = "PBGetItems";
            this.PBGetItems.Size = new System.Drawing.Size(992, 35);
            this.PBGetItems.TabIndex = 1;
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
            // ItemB2BExpReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 753);
            this.Controls.Add(this.GridItems);
            this.Controls.Add(this.PBGetItems);
            this.Controls.Add(this.BtnExportToExcel);
            this.Controls.Add(this.BtnGetData);
            this.Name = "ItemB2BExpReport";
            this.Text = "Ürün Açıklama Durumları";
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.Button BtnExportToExcel;
        private System.Windows.Forms.ProgressBar PBGetItems;
        private System.Windows.Forms.DataGridView GridItems;
    }
}