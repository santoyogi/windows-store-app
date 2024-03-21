namespace SSS
{
    partial class Search
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
            this.components = new System.ComponentModel.Container();
            this.searchLbl = new System.Windows.Forms.Label();
            this.dropLbl = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchTypeCmb = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.inventoryItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cs3280DemoDataSet = new SSS.cs3280DemoDataSet();
            this.inventoryItemsTableAdapter = new SSS.cs3280DemoDataSetTableAdapters.InventoryItemsTableAdapter();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.itemTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3280DemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(74, 67);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(125, 16);
            this.searchLbl.TabIndex = 0;
            this.searchLbl.Text = "Search by keyword:";
            // 
            // dropLbl
            // 
            this.dropLbl.AutoSize = true;
            this.dropLbl.Location = new System.Drawing.Point(77, 113);
            this.dropLbl.Name = "dropLbl";
            this.dropLbl.Size = new System.Drawing.Size(128, 16);
            this.dropLbl.TabIndex = 1;
            this.dropLbl.Text = "Search by item type:";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(252, 60);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(100, 22);
            this.searchTxt.TabIndex = 2;
            // 
            // searchTypeCmb
            // 
            this.searchTypeCmb.FormattingEnabled = true;
            this.searchTypeCmb.Items.AddRange(new object[] {
            ""});
            this.searchTypeCmb.Location = new System.Drawing.Point(252, 113);
            this.searchTypeCmb.Name = "searchTypeCmb";
            this.searchTypeCmb.Size = new System.Drawing.Size(121, 24);
            this.searchTypeCmb.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(252, 206);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(776, 27);
            this.fillByToolStrip.TabIndex = 6;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // inventoryItemsBindingSource
            // 
            this.inventoryItemsBindingSource.DataMember = "InventoryItems";
            this.inventoryItemsBindingSource.DataSource = this.cs3280DemoDataSet;
            // 
            // cs3280DemoDataSet
            // 
            this.cs3280DemoDataSet.DataSetName = "cs3280DemoDataSet";
            this.cs3280DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryItemsTableAdapter
            // 
            this.inventoryItemsTableAdapter.ClearBeforeFill = true;
            // 
            // dgSearch
            // 
            this.dgSearch.AutoGenerateColumns = false;
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemTitleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgSearch.DataSource = this.inventoryItemsBindingSource;
            this.dgSearch.Location = new System.Drawing.Point(77, 294);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.RowHeadersWidth = 51;
            this.dgSearch.RowTemplate.Height = 24;
            this.dgSearch.Size = new System.Drawing.Size(687, 150);
            this.dgSearch.TabIndex = 7;
            // 
            // itemTitleDataGridViewTextBoxColumn
            // 
            this.itemTitleDataGridViewTextBoxColumn.DataPropertyName = "ItemTitle";
            this.itemTitleDataGridViewTextBoxColumn.HeaderText = "ItemTitle";
            this.itemTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemTitleDataGridViewTextBoxColumn.Name = "itemTitleDataGridViewTextBoxColumn";
            this.itemTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTypeCmb);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.dropLbl);
            this.Controls.Add(this.searchLbl);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3280DemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label dropLbl;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ComboBox searchTypeCmb;
        private System.Windows.Forms.Button searchBtn;
        private cs3280DemoDataSet cs3280DemoDataSet;
        private System.Windows.Forms.BindingSource inventoryItemsBindingSource;
        private cs3280DemoDataSetTableAdapters.InventoryItemsTableAdapter inventoryItemsTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}