using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            #region Data Binding

            try
            {
                Organization.CategoryDataTable dtCatTable = Utility.GetCategories();
                searchTypeCmb.DataSource = dtCatTable;
                searchTypeCmb.DisplayMember = dtCatTable.CategoryColumn.ColumnName;
                searchTypeCmb.ValueMember = dtCatTable.IDColumn.ColumnName;

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL specific error. Contact your administrator. Phone number, email address" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled error. Contact your administrator. Phone number, email address" + ex.Message);
            }

            #endregion
        }

        private void removeRow(int index)
        {
            CurrencyManager curr = (CurrencyManager)BindingContext[dgSearch.DataSource];
            curr.SuspendBinding();
            dgSearch.Rows[index].Visible = false;
            curr.ResumeBinding();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            dgSearch.DataSource = Utility.GetInventory();
            if (searchTxt.Text != "" && searchTypeCmb.SelectedIndex == 0)
            {
                for (int i = 0; i < Utility.GetInventory().Count; i++)
                {
                    var row = dgSearch.Rows[i];
                    string keyWord = searchTxt.Text;
                    string title = Utility.GetInventory()[i].ItemTitle;
                    if (title.Contains(keyWord))
                    {
                        row.Selected = true;
                        row.Visible = true;
                    }
                    else
                    {
                        removeRow(i);
                    }
                }
            }
            else if(searchTxt.Text != "" && searchTypeCmb.SelectedIndex > 0)
            {
                for (int i = 0; i < Utility.GetInventory().Count; i++)
                {
                    var row = dgSearch.Rows[i];
                    string keyWord = searchTxt.Text;
                    string title = Utility.GetInventory()[i].ItemTitle;

                    int category = searchTypeCmb.SelectedIndex;
                    int index = Utility.GetInventory()[i].Category;
                    if (title.Contains(keyWord) && category == index)
                    {
                        row.Selected = true;
                        row.Visible = true;
                    }
                    else
                    {
                        removeRow(i);
                    }
                }
            }
            else if (searchTxt.Text == "" && searchTypeCmb.SelectedIndex > 0)
            {
                for (int i = 0; i < Utility.GetInventory().Count; i++)
                {
                    var row = dgSearch.Rows[i];
                    int category = searchTypeCmb.SelectedIndex;
                    int index = Utility.GetInventory()[i].Category;
                    if (category == index)
                    {
                        row.Selected = true;
                        row.Visible = true;
                    }
                    else
                    {
                        removeRow(i);
                    }
                }
             }
            else
            {
                dgSearch.DataSource = Utility.GetInventory();
            }
            
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cs3280DemoDataSet.InventoryItems' table. You can move, or remove it, as needed.
            this.inventoryItemsTableAdapter.Fill(this.cs3280DemoDataSet.InventoryItems);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryItemsTableAdapter.FillBy(this.cs3280DemoDataSet.InventoryItems);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
