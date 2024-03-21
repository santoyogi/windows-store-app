using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Utility
    {
        public static Organization.CategoryDataTable GetCategories()
        {
            Organization.CategoryDataTable dtCatTable = new Organization.CategoryDataTable();
            OrganizationTableAdapters.CategoryTableAdapter catAdapter = new OrganizationTableAdapters.CategoryTableAdapter();
            catAdapter.Fill(dtCatTable);

            return dtCatTable;
        }

        public static Organization.CompanyDataTable GetCompanies()
        {
            Organization.CompanyDataTable dtCompTable = new Organization.CompanyDataTable();
            OrganizationTableAdapters.CompanyTableAdapter compAdapter = new OrganizationTableAdapters.CompanyTableAdapter();
            compAdapter.Fill(dtCompTable);

            return dtCompTable;
        }

        public static Organization.InventoryItemsDataTable GetInventory()
        {
            Organization.InventoryItemsDataTable dtInventoryTable = new Organization.InventoryItemsDataTable();
            OrganizationTableAdapters.InventoryItemsTableAdapter inventoryAdapter = new OrganizationTableAdapters.InventoryItemsTableAdapter();
            inventoryAdapter.Fill(dtInventoryTable);

            return dtInventoryTable;
        }

        public static void UpdateCompanies(int id, string compName, string contactNum, string address)
        {
            Organization.CompanyDataTable dtCompTable = new Organization.CompanyDataTable();
            OrganizationTableAdapters.CompanyTableAdapter compAdapter = new OrganizationTableAdapters.CompanyTableAdapter();
            compAdapter.Fill(dtCompTable);

            foreach (Organization.CompanyRow row in dtCompTable.Rows)
            {
                if(row.ID == id)
                {
                    row.CompanyName = compName;
                    row.ContactNumber = contactNum;
                    row.Address = address;
                }
            }
            compAdapter.Update(dtCompTable);
        }

        public static void UpdateInventory(int id, string title, int category, double price, string description, int companyID, Double length, Double width, Double height, Double weight, string ISBN, string author,
            int bookType, DateTime packagingDate, DateTime expirationDate, int groceryCategory)
        {
            Organization.InventoryItemsDataTable dtInventoryTable = new Organization.InventoryItemsDataTable();
            OrganizationTableAdapters.InventoryItemsTableAdapter inventoryAdapter = new OrganizationTableAdapters.InventoryItemsTableAdapter();
            inventoryAdapter.Fill(dtInventoryTable);

            foreach (Organization.InventoryItemsRow row in dtInventoryTable.Rows)
            {
                if (row.ID == id)
                {
                    row.ItemTitle = title;
                    row.Category = category;
                    row.Price = price;
                    row.Description = description;
                    row.CompanyId = companyID;
                    row.Length = length;
                    row.Width = width;
                    row.Height = height;
                    row.Weight = weight;
                    row.ISBN = ISBN;
                    row.Author = author;
                    row.BookType = bookType;
                    row.PackagingDate = packagingDate;
                    row.ExpirationDate = expirationDate;
                    row.GrocerCategory = groceryCategory;
                }
            }
            inventoryAdapter.Update(dtInventoryTable);
        }

        public static void DeleteByCompId(int compID)
        {
            Organization.CompanyDataTable dtCompTable = new Organization.CompanyDataTable();
            OrganizationTableAdapters.CompanyTableAdapter compAdapter = new OrganizationTableAdapters.CompanyTableAdapter();
            compAdapter.Fill(dtCompTable);

            foreach (Organization.CompanyRow compRow in dtCompTable.Rows)
            {
                if (compRow.ID == compID)
                {
                    compRow.Delete();
                }
            }
            compAdapter.Update(dtCompTable);
        }

        public static void DeleteByInventoryID(int inventoryID)
        {
            Organization.InventoryItemsDataTable dtInventoryTable = new Organization.InventoryItemsDataTable();
            OrganizationTableAdapters.InventoryItemsTableAdapter inventoryAdapter = new OrganizationTableAdapters.InventoryItemsTableAdapter();
            inventoryAdapter.Fill(dtInventoryTable);

            foreach (Organization.InventoryItemsRow inventRow in dtInventoryTable.Rows)
            {
                if (inventRow.ID == inventoryID)
                {
                    inventRow.Delete();
                }
            }
            inventoryAdapter.Update(dtInventoryTable);
        }

        public static void SaveInventoryItem(int id, string title, int category, Double price, string description,
            int companyID, Double length, Double width, Double height, Double weight, string ISBN, string author,  
            int bookType, DateTime packagingDate, DateTime expirationDate, int groceryCategory, int quantity)
        {
            OrganizationTableAdapters.InventoryItemsTableAdapter inventAdapter = new OrganizationTableAdapters.InventoryItemsTableAdapter();
            Organization.InventoryItemsDataTable dtInventTable = new Organization.InventoryItemsDataTable();
            inventAdapter.Fill(dtInventTable);

            if (quantity == 0)
            {
                UpdateInventory(id, title, category, price, description, companyID, length, width, height, weight, ISBN, author, bookType, packagingDate, expirationDate, groceryCategory);
                return;
            }

            Organization.InventoryItemsRow newRow = dtInventTable.NewInventoryItemsRow();
            newRow.ID = id;
            newRow.ItemTitle = title;
            newRow.Category = category;
            newRow.Price = price;
            newRow.Description = description;
            newRow.CompanyId = companyID;
            newRow.Length = length;
            newRow.Width = width;
            newRow.Height = height;
            newRow.Weight = weight;
            newRow.ISBN = ISBN;
            newRow.Author = author;
            newRow.BookType = bookType;
            newRow.PackagingDate = packagingDate;
            newRow.ExpirationDate = expirationDate;
            newRow.GrocerCategory = groceryCategory;

            dtInventTable.AddInventoryItemsRow(newRow);

            inventAdapter.Update(dtInventTable);
        }
    }
}
