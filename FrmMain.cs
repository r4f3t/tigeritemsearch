using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemSearchTiger
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ürünAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSearchForm fc = new ItemSearchForm();
            fc.MdiParent = this;
            fc.Show();
        }

        private void ürünAçıklamaExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemB2BExpReport fc = new ItemB2BExpReport();
            fc.MdiParent = this;
            fc.Show();
        }
    }
}
