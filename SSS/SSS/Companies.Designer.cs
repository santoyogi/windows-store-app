﻿namespace SSS
{
    partial class Companies
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
            this.dgCompanies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCompanies
            // 
            this.dgCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompanies.Location = new System.Drawing.Point(35, 60);
            this.dgCompanies.Name = "dgCompanies";
            this.dgCompanies.RowHeadersWidth = 51;
            this.dgCompanies.RowTemplate.Height = 24;
            this.dgCompanies.Size = new System.Drawing.Size(707, 260);
            this.dgCompanies.TabIndex = 0;
            this.dgCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompanies_CellClick);
            // 
            // Companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgCompanies);
            this.Name = "Companies";
            this.Text = "Companies";
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCompanies;
    }
}