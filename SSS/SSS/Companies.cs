using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace SSS
{
    public partial class Companies : Form
    {
        public Companies()
        {
            InitializeComponent();

            #region DataGrid Load
            dgCompanies.DataSource = Utility.GetCompanies();

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteButton";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgCompanies.Columns.Add(deleteColumn);

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.HeaderText = "Use to Update";
            updateColumn.Text = "Update";
            updateColumn.Name = "updateButton";
            updateColumn.UseColumnTextForButtonValue = true;

            dgCompanies.Columns.Add(updateColumn);
            dgCompanies.CellClick += dgCompanies_CellClick;
            #endregion
        }

        private void RefreshGridData()
        {
            // get the current data from the database. 
            // and assign it it grid. 

            Organization.CompanyDataTable dtCompTable = Utility.GetCompanies();
            dgCompanies.DataSource = dtCompTable;

        }

        private void dgCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentCompId = -1;
            
            DataGridView dg = (DataGridView)sender;
            //MessageBox.Show(e.RowIndex + " " + e.ColumnIndex);
            if(e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow currRow = dg.Rows[e.RowIndex];

            if(currRow.Cells["ID"].Value != null) { 
                currentCompId = int.Parse(currRow.Cells["ID"].Value.ToString());
            }

            if (dg.SelectedCells.Count == 1)
            { 
                if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    if (selectedCell.Value.Equals("Delete"))
                    {

                        Console.WriteLine("Delete is Clicked. Current Company ID is: " + currentCompId);
                        Utility.DeleteByCompId(currentCompId);

                        RefreshGridData();

                    }
                    else if (selectedCell.Value.Equals("Update"))
                    {
                        string sCompId = currRow.Cells["ID"].Value.ToString();
                        int compId = string.IsNullOrEmpty(sCompId) ? 0 : int.Parse(sCompId);
                        string compName = currRow.Cells["CompanyName"].Value.ToString();
                        string contact = currRow.Cells["ContactNumber"].Value.ToString();
                        string address = currRow.Cells["Address"].Value.ToString();
                        Utility.UpdateCompanies(compId, compName, contact, address);
                        dgCompanies.DataSource = Utility.GetCompanies();
                        RefreshGridData();
                    }
                }
                return;
               
            }
           
        }
    }
}
