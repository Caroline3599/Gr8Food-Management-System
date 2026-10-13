using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DatabaseHelper = Gr8Food.Classes.DBHelper;

namespace System_Admin_Assignment
{
    public class Order
    {

        // Empty Default Constructor
        public Order()
        {
        }

        // Pull Only Completed Orders 
        public DataTable GetFilteredSalesReport(object monthParam, object yearParam, string category, string chefName)
        {
            DataTable reportTable = new DataTable();

            // The entire SQL Join and filter tracking logic encapsulated inside the business layer
            string query = @"
        SELECT 
            o.[OrderID],
            o.[OrderDate],
            m.[ItemName],
            m.[Category],
            od.[Quantity],
            m.[Price] AS [UnitPrice],
            (od.[Quantity] * m.[Price]) AS [TotalPrice],
            c.[Name] AS [ChefName]
        FROM [dbo].[Order] o
        INNER JOIN [dbo].[OrderDetails] od ON o.[OrderID] = od.[OrderID]
        INNER JOIN [dbo].[Menu] m ON od.[MenuID] = m.[MenuID]
        LEFT JOIN [dbo].[Chef] c ON m.[ChefID] = c.[ChefID]
        WHERE o.[OrderStatus] = 'Complete' ";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        // 1. Month Filter Processing
                        if (monthParam != null)
                        {
                            query += " AND MONTH(o.[OrderDate]) = @Month ";
                            cmd.Parameters.AddWithValue("@Month", monthParam);
                        }

                        // 2. Year Filter Processing
                        if (yearParam != null)
                        {
                            query += " AND YEAR(o.[OrderDate]) = @Year ";
                            cmd.Parameters.AddWithValue("@Year", yearParam);
                        }

                        // 3. Category Filter Processing
                        if (!string.IsNullOrEmpty(category) && category != "All")
                        {
                            query += " AND m.[Category] = @Category ";
                            cmd.Parameters.AddWithValue("@Category", category);
                        }

                        // 4. Chef Filter Processing
                        if (!string.IsNullOrEmpty(chefName) && chefName != "All")
                        {
                            query += " AND c.[Name] = @ChefName ";
                            cmd.Parameters.AddWithValue("@ChefName", chefName);
                        }

                        query += " ORDER BY o.[OrderDate] DESC;";

                        cmd.CommandText = query;
                        cmd.Connection = conn;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            conn.Open();
                            adapter.Fill(reportTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error compiling filtered sales report details in business layer: " + ex.Message);
            }

            return reportTable;
        }
    }
}