namespace SSS
{
    partial class InventoryForm
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpBxFurniture = new System.Windows.Forms.GroupBox();
            this.grpBxGrocery = new System.Windows.Forms.GroupBox();
            this.lblGroceryCategory = new System.Windows.Forms.Label();
            this.cmbGrocery = new System.Windows.Forms.ComboBox();
            this.ExpireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PackagingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblPackaging = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBxBook = new System.Windows.Forms.GroupBox();
            this.lblBookType = new System.Windows.Forms.Label();
            this.cmbBookType = new System.Windows.Forms.ComboBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.quantityEp = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBxFurniture.SuspendLayout();
            this.grpBxGrocery.SuspendLayout();
            this.grpBxBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(213, 25);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 22);
            this.txtItem.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(213, 63);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(140, 52);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 3;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(140, 106);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 4;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(428, 52);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 5;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(428, 105);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 6;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(76, 29);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(32, 16);
            this.lblItem.TabIndex = 7;
            this.lblItem.Text = "Item";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(75, 67);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(72, 104);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(61, 52);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(47, 16);
            this.lblLength.TabIndex = 10;
            this.lblLength.Text = "Length";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(62, 108);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 16);
            this.lblWidth.TabIndex = 11;
            this.lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(355, 52);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(46, 16);
            this.lblHeight.TabIndex = 12;
            this.lblHeight.Text = "Height";
            this.lblHeight.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(355, 106);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(49, 16);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Text = "Weight";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(207, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(386, 378);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpBxFurniture
            // 
            this.grpBxFurniture.Controls.Add(this.lblLength);
            this.grpBxFurniture.Controls.Add(this.txtLength);
            this.grpBxFurniture.Controls.Add(this.lblWidth);
            this.grpBxFurniture.Controls.Add(this.lblWeight);
            this.grpBxFurniture.Controls.Add(this.txtWidth);
            this.grpBxFurniture.Controls.Add(this.lblHeight);
            this.grpBxFurniture.Controls.Add(this.txtWeight);
            this.grpBxFurniture.Controls.Add(this.txtHeight);
            this.grpBxFurniture.Location = new System.Drawing.Point(61, 177);
            this.grpBxFurniture.Name = "grpBxFurniture";
            this.grpBxFurniture.Size = new System.Drawing.Size(636, 144);
            this.grpBxFurniture.TabIndex = 16;
            this.grpBxFurniture.TabStop = false;
            this.grpBxFurniture.Text = "Dimensions";
            this.grpBxFurniture.Visible = false;
            this.grpBxFurniture.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpBxGrocery
            // 
            this.grpBxGrocery.Controls.Add(this.lblGroceryCategory);
            this.grpBxGrocery.Controls.Add(this.cmbGrocery);
            this.grpBxGrocery.Controls.Add(this.ExpireDateTimePicker);
            this.grpBxGrocery.Controls.Add(this.PackagingDateTimePicker);
            this.grpBxGrocery.Controls.Add(this.lblPackaging);
            this.grpBxGrocery.Controls.Add(this.label2);
            this.grpBxGrocery.Location = new System.Drawing.Point(67, 174);
            this.grpBxGrocery.Name = "grpBxGrocery";
            this.grpBxGrocery.Size = new System.Drawing.Size(636, 144);
            this.grpBxGrocery.TabIndex = 17;
            this.grpBxGrocery.TabStop = false;
            this.grpBxGrocery.Text = "Packaging and Expiration Dates";
            this.grpBxGrocery.Visible = false;
            // 
            // lblGroceryCategory
            // 
            this.lblGroceryCategory.AutoSize = true;
            this.lblGroceryCategory.Location = new System.Drawing.Point(387, 52);
            this.lblGroceryCategory.Name = "lblGroceryCategory";
            this.lblGroceryCategory.Size = new System.Drawing.Size(62, 16);
            this.lblGroceryCategory.TabIndex = 15;
            this.lblGroceryCategory.Text = "Category";
            // 
            // cmbGrocery
            // 
            this.cmbGrocery.FormattingEnabled = true;
            this.cmbGrocery.Items.AddRange(new object[] {
            "Produce",
            "Fruit",
            "Meat",
            "Fish",
            "Dairy",
            "Beverages"});
            this.cmbGrocery.Location = new System.Drawing.Point(464, 46);
            this.cmbGrocery.Name = "cmbGrocery";
            this.cmbGrocery.Size = new System.Drawing.Size(121, 24);
            this.cmbGrocery.TabIndex = 14;
            // 
            // ExpireDateTimePicker
            // 
            this.ExpireDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpireDateTimePicker.Location = new System.Drawing.Point(143, 105);
            this.ExpireDateTimePicker.Name = "ExpireDateTimePicker";
            this.ExpireDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ExpireDateTimePicker.TabIndex = 13;
            // 
            // PackagingDateTimePicker
            // 
            this.PackagingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PackagingDateTimePicker.Location = new System.Drawing.Point(143, 47);
            this.PackagingDateTimePicker.Name = "PackagingDateTimePicker";
            this.PackagingDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.PackagingDateTimePicker.TabIndex = 12;
            // 
            // lblPackaging
            // 
            this.lblPackaging.AutoSize = true;
            this.lblPackaging.Location = new System.Drawing.Point(24, 52);
            this.lblPackaging.Name = "lblPackaging";
            this.lblPackaging.Size = new System.Drawing.Size(104, 16);
            this.lblPackaging.TabIndex = 10;
            this.lblPackaging.Text = "Packaging Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Expiration Date";
            // 
            // grpBxBook
            // 
            this.grpBxBook.Controls.Add(this.lblBookType);
            this.grpBxBook.Controls.Add(this.cmbBookType);
            this.grpBxBook.Controls.Add(this.lblISBN);
            this.grpBxBook.Controls.Add(this.txtISBN);
            this.grpBxBook.Controls.Add(this.lblAuthor);
            this.grpBxBook.Controls.Add(this.txtAuthor);
            this.grpBxBook.Location = new System.Drawing.Point(61, 167);
            this.grpBxBook.Name = "grpBxBook";
            this.grpBxBook.Size = new System.Drawing.Size(636, 144);
            this.grpBxBook.TabIndex = 18;
            this.grpBxBook.TabStop = false;
            this.grpBxBook.Text = "Book Information";
            this.grpBxBook.Visible = false;
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(316, 55);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(74, 16);
            this.lblBookType.TabIndex = 13;
            this.lblBookType.Text = "Book Type";
            // 
            // cmbBookType
            // 
            this.cmbBookType.FormattingEnabled = true;
            this.cmbBookType.Items.AddRange(new object[] {
            "Horror",
            "SciFi",
            "Romance",
            "Historical",
            "Mystery",
            "NonFiction"});
            this.cmbBookType.Location = new System.Drawing.Point(407, 52);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.Size = new System.Drawing.Size(121, 24);
            this.cmbBookType.TabIndex = 12;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(56, 52);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(38, 16);
            this.lblISBN.TabIndex = 10;
            this.lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(140, 52);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 22);
            this.txtISBN.TabIndex = 3;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(55, 108);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(45, 16);
            this.lblAuthor.TabIndex = 11;
            this.lblAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(140, 106);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtAuthor.TabIndex = 4;
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(73, 140);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(67, 16);
            this.lblItemType.TabIndex = 17;
            this.lblItemType.Text = "Item Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(213, 135);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 18;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(213, 100);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(496, 22);
            this.txtDescription.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(76, 333);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 29;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(212, 330);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 30;
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantity_Validating);
            // 
            // dgInventory
            // 
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventory.Location = new System.Drawing.Point(67, 422);
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.RowHeadersWidth = 51;
            this.dgInventory.RowTemplate.Height = 24;
            this.dgInventory.Size = new System.Drawing.Size(636, 150);
            this.dgInventory.TabIndex = 31;
            this.dgInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInventory_CellClick);
            // 
            // quantityEp
            // 
            this.quantityEp.ContainerControl = this;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.dgInventory);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.grpBxBook);
            this.Controls.Add(this.grpBxGrocery);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.grpBxFurniture);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItem);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.grpBxFurniture.ResumeLayout(false);
            this.grpBxFurniture.PerformLayout();
            this.grpBxGrocery.ResumeLayout(false);
            this.grpBxGrocery.PerformLayout();
            this.grpBxBook.ResumeLayout(false);
            this.grpBxBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpBxFurniture;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblPackaging;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBxGrocery;
        private System.Windows.Forms.GroupBox grpBxBook;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.ComboBox cmbBookType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker PackagingDateTimePicker;
        private System.Windows.Forms.DateTimePicker ExpireDateTimePicker;
        private System.Windows.Forms.Label lblGroceryCategory;
        private System.Windows.Forms.ComboBox cmbGrocery;
        private System.Windows.Forms.DataGridView dgInventory;
        private System.Windows.Forms.ErrorProvider quantityEp;
    }
}