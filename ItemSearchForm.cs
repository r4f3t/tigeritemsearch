using ItemSearchTiger.BusinessLayer;
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
    public partial class ItemSearchForm : Form
    {
        public ItemSearchForm()
        {
            InitializeComponent();
        }
        ItemSearchManager itemSearchManager = new ItemSearchManager();
        private void TXTGeneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                LBItems.Items.Add("Veriler Üzerinde Arama Yapılıyor");
                var list= itemSearchManager.GetItems(TXTGeneral.Text);
                LBItems.Items.Clear();
                foreach (var item in list)
                {
                    LBItems.Items.Add(item);
                }
                
            }
        }
    }
}
