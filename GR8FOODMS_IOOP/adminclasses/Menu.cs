using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using DatabaseHelper = Gr8Food.Classes.DBHelper;

namespace System_Admin_Assignment
{
    public class Menu
    {
        private int _MenuID;
        private string _MenuName;
        private int _Price;
        private string _Category;
        private string _Status;
        private int _ChefID;
        private int _StockQuantity;

        public int ItemID
        {
            get { return _MenuID; }
        }

        public string MenuName
        {
            get { return _MenuName; }
        }

        public decimal Price
        {
            get { return _Price; }
        }

        public string Category
        {
            get { return _Category; }
        }

        public string Status
        {
            get { return _Status; }
        }

        public int ChefID
        {
            get { return _ChefID; }
        }

        public int StockQuantity
        {
            get { return _StockQuantity; }
        }

        // Empty Default Constructor
        public Menu()
        {
        }

        // Get Menu Items with Chef Names
        public DataTable GetMenuItemsWithChefDetails()
        {
            DataTable menuTable = new DataTable();

            string query = @"SELECT 
                                m.[MenuID], 
                                m.[ItemName], 
                                m.[Price], 
                                c.[Name] AS [CreatedByChef]
                             FROM [dbo].[Menu] m
                             INNER JOIN [dbo].[Chef] c ON m.[ChefID] = c.[ChefID]
                             ORDER BY m.[ItemName] ASC";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            conn.Open();
                            adapter.Fill(menuTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error pulling menu data and chef profile records: " + ex.Message);
            }

            return menuTable;
        }
    }
}