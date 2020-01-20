using ItemSearchTiger.BusinessLayer.Concrete;
using ItemSearchTiger.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemSearchTiger
{
    public partial class ItemB2BExpReport : Form
    {
        public ItemB2BExpReport()
        {
            InitializeComponent();
        }
        ItemB2BExpReportManager manager = new ItemB2BExpReportManager();
        private  void BtnGetData_Click(object sender, EventArgs e)
        {
            //var items = await db.LG_206_ITEMS.Select(x => new ItemWithExp { CODE = x.CODE, LOGICALREF = x.LOGICALREF }).ToListAsync();

            var oldText = BtnGetData.Text;
            BtnGetData.Text = "Veriler Alınıyor...";
            BtnGetData.Enabled = false;
            GridItems.DataSource = manager.GetItems();
            BtnGetData.Text = oldText;
            BtnGetData.Enabled = true;
        }

        private void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(GridItems, sfd.FileName); // Here dataGridview1 is your grid view name
            }   // creating Excel Application  

        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
    }
}
