using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SSS
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();

            #region Data Binding

            try
            {
                Organization.CategoryDataTable dtCatTable = Utility.GetCategories();
                cmbType.DataSource = dtCatTable;
                cmbType.DisplayMember = dtCatTable.CategoryColumn.ColumnName;
                cmbType.ValueMember = dtCatTable.IDColumn.ColumnName;

                Organization.CompanyDataTable dtCompanyTable = Utility.GetCompanies();
                dgInventory.DataSource = Utility.GetInventory();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL specific error. Contact your administrator. Phone number, email address" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled error. Contact your administrator. Phone number, email address" + ex.Message);
            }

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteButton";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgInventory.Columns.Add(deleteColumn);

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.HeaderText = "Use to Update";
            updateColumn.Text = "Update";
            updateColumn.Name = "updateButton";
            updateColumn.UseColumnTextForButtonValue = true;

            dgInventory.Columns.Add(updateColumn);
            dgInventory.CellClick += dgInventory_CellClick;

            //Hide columns

            dgInventory.Columns["ID"].Visible = false;
            dgInventory.Columns["CompanyId"].Visible = false;
            dgInventory.Columns["Length"].Visible = false;
            dgInventory.Columns["Width"].Visible = false;
            dgInventory.Columns["Height"].Visible = false;
            dgInventory.Columns["Weight"].Visible = false;
            dgInventory.Columns["ISBN"].Visible = false;
            dgInventory.Columns["Author"].Visible = false;
            dgInventory.Columns["BookType"].Visible = false;
            dgInventory.Columns["PackagingDate"].Visible = false;
            dgInventory.Columns["ExpirationDate"].Visible = false;
            dgInventory.Columns["GrocerCategory"].Visible = false;


            #endregion
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            grpBxFurniture.Parent = grpBxGrocery.Parent = grpBxBook.Parent =this;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inventoryInfo = string.Empty;
            inventoryInfo += cmbType.Text + " Item\r\n";
            inventoryInfo += "Item: " + txtItem.Text + "\r\n";
            inventoryInfo += "Price: " + txtPrice.Text + "\r\n";
            inventoryInfo += "Description: " + txtDescription.Text + "\r\n";


            if (cmbType.SelectedIndex == 0)
            {
                inventoryInfo += "ISBN: " + txtISBN.Text + "\r\n" + "Author: "
                + txtAuthor.Text + "\r\n" + "Book Genre: " + cmbBookType.Text;
            }

            else if (cmbType.SelectedIndex == 1)
            {
                inventoryInfo += "Dimensions: " + txtLength.Text + " x " + txtWidth.Text
                + " x " + txtHeight.Text + " \r\n" + "Weight: " + txtWeight.Text;
            }
            else if (cmbType.SelectedIndex == 2)
            {
                inventoryInfo += "Packaging Date: " + PackagingDateTimePicker.Text + "\r\n" + "Expiration Date: "
                + ExpireDateTimePicker.Text;
            }

            //string.IsNullOrEmpty(currRow.Cells["ID"].Value.ToString()) ? 0 : int.Parse(currRow.Cells["ID"].Value.ToString());

            int id = int.Parse(dgInventory.CurrentRow.Cells["ID"].Value.ToString());
            string title = txtItem.Text;
            int category = cmbType.SelectedIndex;
            double price = double.Parse(txtPrice.Text);
            string description = txtDescription.Text;
            int companyId = 0;
            double length = 0;
            double width = 0;
            double height = 0;
            double weight = 0;
            string ISBN = "";
            string author = "";
            int bookType = 0;
            DateTime expiration = DateTime.Today.AddDays(1);
            DateTime packaging = DateTime.Today.AddDays(1);
            int groceryCategory = 0;


            if (txtLength.Text != "") { length = double.Parse(txtLength.Text); }
            if (txtWidth.Text != "") { width = double.Parse(txtWidth.Text); }
            if (txtHeight.Text != "") { height = double.Parse(txtHeight.Text); }
            if (txtWeight.Text != "") { weight = double.Parse(txtWeight.Text); }
            if (txtISBN.Text != "") { ISBN = txtISBN.Text; }
            if (txtAuthor.Text != "") { author = txtAuthor.Text; }
            if (cmbBookType.SelectedIndex != -1) {bookType = cmbBookType.SelectedIndex; }
            if (ExpireDateTimePicker.Text != "") { expiration = DateTime.Parse(ExpireDateTimePicker.Text); }
            if (PackagingDateTimePicker.Text != "") { packaging = DateTime.Parse(PackagingDateTimePicker.Text); }
            if (cmbGrocery.SelectedIndex != -1) { groceryCategory = cmbGrocery.SelectedIndex; }



            if (dgInventory.SelectedCells.Count == 1)
            {
                Utility.UpdateInventory(id, title, category, price, description, companyId, length, width, height, weight, ISBN, author, bookType, expiration, packaging, groceryCategory);
            }
            else
            {
                //int bookType = string.IsNullOrEmpty(currRow.Cells["BookType"].Value.ToString()) ? 0 : int.Parse(currRow.Cells["BookType"].Value.ToString());
                int quantity = string.IsNullOrEmpty(txtQuantity.Text) ? 0 : int.Parse(txtQuantity.Text);
                if (quantity > 0)
                {
                    for (int i = 0; i < quantity; i++)
                    {
                        Utility.SaveInventoryItem(id, title, category, price, description, companyId,
                        length, width, height, weight, ISBN, author, bookType, packaging, expiration, groceryCategory, quantity);
                    }
                }
                else {
                    Utility.SaveInventoryItem(id, title, category, price, description, companyId,
                      length, width, height, weight, ISBN, author, bookType, packaging, expiration, groceryCategory, quantity);
                }
                
            }
            RefreshGridData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 1)
            {
                grpBxFurniture.Visible = false;
                grpBxGrocery.Visible = false;
                grpBxBook.Visible = true;
            }
            else if (cmbType.SelectedIndex == 2)
            {
                grpBxGrocery.Visible = false;
                grpBxBook.Visible = false;
                grpBxFurniture.Visible = true;
            }
            else if (cmbType.SelectedIndex == 3)
            {
                grpBxFurniture.Visible = false;
                grpBxBook.Visible = false;
                grpBxGrocery.Visible = true;
            }
            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtItem.Text = String.Empty;
            txtPrice.Text = String.Empty;
            txtDescription.Text = String.Empty;
            cmbType.SelectedIndex = 0;
            grpBxFurniture.Visible = false;
            grpBxGrocery.Visible = false;
            grpBxBook.Visible = false;
        }
        private void RefreshGridData()
        {
            // get the current data from the database. 
            // and assign it it grid. 

            Organization.InventoryItemsDataTable dtInventoryTable = Utility.GetInventory();
            dgInventory.DataSource = dtInventoryTable;

        }

        private void dgInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentInventoryId = -1;

            DataGridView dg = (DataGridView)sender;
            //MessageBox.Show(e.RowIndex + " " + e.ColumnIndex);
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow currRow = dg.Rows[e.RowIndex];
            if (currRow.Cells["ID"].Value != null)
            {
                currentInventoryId = int.Parse(currRow.Cells["ID"].Value.ToString());
            }

            if (e.ColumnIndex == -1)
            {
                currentInventoryId = int.Parse(currRow.Cells["ID"].Value.ToString());

                if (int.Parse(currRow.Cells["Category"].Value.ToString()) != 2)
                {
                    currRow.Cells["PackagingDate"].Value = DateTime.Now;
                    currRow.Cells["ExpirationDate"].Value = DateTime.Now;
                    if(int.Parse(currRow.Cells["Category"].Value.ToString()) == 1)
                    {
                        grpBxFurniture.Visible = true;
                        grpBxGrocery.Visible = false;
                        grpBxBook.Visible = false;
                    }
                    else if (int.Parse(currRow.Cells["Category"].Value.ToString()) == 0)
                    {
                        grpBxFurniture.Visible = false;
                        grpBxGrocery.Visible = false;
                        grpBxBook.Visible = true;
                    }
                }

                if (int.Parse(currRow.Cells["Category"].Value.ToString()) == 2)
                {
                    grpBxFurniture.Visible = false;
                    grpBxGrocery.Visible = true;
                    grpBxBook.Visible = false;
                }

                txtItem.Text = currRow.Cells["ItemTitle"].Value.ToString();
                cmbType.Text = currRow.Cells["Category"].Value.ToString();
                txtPrice.Text = currRow.Cells["Price"].Value.ToString();
                txtDescription.Text = currRow.Cells["Description"].Value.ToString();
                txtLength.Text = currRow.Cells["Length"].Value.ToString();
                txtWidth.Text = currRow.Cells["Width"].Value.ToString();
                txtHeight.Text = currRow.Cells["Height"].Value.ToString();
                txtWeight.Text = currRow.Cells["Weight"].Value.ToString();
                txtISBN.Text = currRow.Cells["ISBN"].Value.ToString();
                txtAuthor.Text = currRow.Cells["Author"].Value.ToString();
                cmbBookType.Text = currRow.Cells["BookType"].Value.ToString();
                PackagingDateTimePicker.Text = currRow.Cells["PackagingDate"].Value.ToString();
                ExpireDateTimePicker.Text = currRow.Cells["ExpirationDate"].Value.ToString();
                cmbGrocery.Text = currRow.Cells["GrocerCategory"].Value.ToString();
                


                
                return;
            }


            if (dg.SelectedCells.Count == 1)
            {
                if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    if (selectedCell.Value.Equals("Delete"))
                    {

                        Console.WriteLine("Delete is Clicked. Current Inventory ID is: " + currentInventoryId);
                        Utility.DeleteByInventoryID(currentInventoryId);

                        RefreshGridData();

                    }
                    else if (selectedCell.Value.Equals("Update"))
                    {
                        int sInventoryId = string.IsNullOrEmpty(currRow.Cells["ID"].Value.ToString()) ? 0 : int.Parse(currRow.Cells["ID"].Value.ToString());
                        string title = currRow.Cells["ItemTitle"].Value.ToString();
                        int category = string.IsNullOrEmpty(currRow.Cells["Category"].Value.ToString()) ? 0 : int.Parse(currRow.Cells["Category"].Value.ToString());
                        int company = string.IsNullOrEmpty(currRow.Cells["CompanyId"].Value.ToString()) ? 0 : int.Parse(currRow.Cells["CompanyId"].Value.ToString());
                        double price = string.IsNullOrEmpty(currRow.Cells["Price"].Value.ToString()) ? 0 : double.Parse(currRow.Cells["Price"].Value.ToString());
                        string Description = currRow.Cells["Description"].Value.ToString();
                        double length = string.IsNullOrEmpty(currRow.Cells["Length"].Value.ToString()) ? 0 : double.Parse(currRow.Cells["Length"].Value.ToString());
                        double width = string.IsNullOrEmpty(currRow.Cells["Width"].Value.ToString()) ? 0 : double.Parse(currRow.Cells["Width"].Value.ToString());
                        double Height = string.IsNullOrEmpty(currRow.Cells["Height"].Value.ToString()) ? 0 : double.Parse(currRow.Cells["Height"].Value.ToString());
                        double weight = string.IsNullOrEmpty(currRow.Cells["Weight"].Value.ToString()) ? 0 : double.Parse(currRow.Cells["Weight"].Value.ToString());
                        string ISBN = currRow.Cells["ISBN"].Value.ToString();
                        string author = currRow.Cells["Author"].Value.ToString();
                        int bookType = string.IsNullOrEmpty(currRow.Cells["BookType"].Value.ToString()) ? 0 : int.Parse(currRow.Cells["BookType"].Value.ToString());
                        DateTime expiration = DateTime.Today.AddDays(1);
                        DateTime packaging = DateTime.Today.AddDays(1);
                        if (ExpireDateTimePicker.Text != "") { expiration = DateTime.Parse(ExpireDateTimePicker.Text); }
                        if (PackagingDateTimePicker.Text != "") { packaging = DateTime.Parse(PackagingDateTimePicker.Text); }
                        int groceryCategory = string.IsNullOrEmpty(currRow.Cells["GrocerCategory"].Value.ToString()) ? 0 : int.Parse(currRow.Cells["GrocerCategory"].Value.ToString());

                        Utility.UpdateInventory(sInventoryId, title, category, price, Description, company, length, width, Height, weight, ISBN, author,
                        bookType, packaging, expiration, groceryCategory);
                        dgInventory.DataSource = Utility.GetInventory();
                        RefreshGridData();
                    }
                }
                return;

            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(txtQuantity.Text) < 0)
            {
                quantityEp.SetError(txtQuantity, "Quantity can't be negative");
            }
        }
    }
}
