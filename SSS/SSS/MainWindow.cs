using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS
{
    public partial class MainWindow : Form
    {
        private Companies compWin;
        private InventoryForm inventoryWin;
        private Search searchWin;
        public MainWindow()
        {
            InitializeComponent();

            inventoryWin = new InventoryForm();
            inventoryWin.MdiParent = this;
            inventoryWin.Show();

            compWin = new Companies();
            compWin.MdiParent = this;

            searchWin = new Search();
            searchWin.MdiParent = this;
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inventoryWin.IsDisposed)
            {
                inventoryWin = new InventoryForm();
                inventoryWin.MdiParent = this;
            }
            inventoryWin.Show();
            searchWin.Hide();
            compWin.Hide();
        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(compWin.IsDisposed)
            {
                compWin = new Companies();
                compWin.MdiParent = this;
            }
            compWin.Show();
            searchWin.Hide();
            inventoryWin.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchWin.IsDisposed)
            {
                searchWin = new Search();
                searchWin.MdiParent = this;
            }
            searchWin.Show();
            compWin.Hide();
            inventoryWin.Hide();
        }
    }
}
