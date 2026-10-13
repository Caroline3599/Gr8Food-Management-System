using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Gr8Food.Classes;


namespace IOOP_Manager
{
    public class ManagerWalletReportRepository
    {
        public DataTable GetCustomers()
        {
            DataTable dt = new DataTable();
            DBHelper db = new DBHelper();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    SELECT 
                        CustomerID,
                        Name
                    FROM [Customer]
                    ORDER BY Name;
                ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }

            return dt;
        }

        public DataTable GetWalletReport(int customerId, int year, int month)
        {
            DataTable dt = new DataTable();

            DBHelper db = new DBHelper();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    SELECT
                        b.BalanceID,
                        b.CustomerID,
                        c.Name AS CustomerName,
                        b.Type,
                        b.Amount,
                        b.[Date],
                        b.RelatedOrderID
                    FROM [Balance] b
                    INNER JOIN [Customer] c
                        ON b.CustomerID = c.CustomerID
                    WHERE
                        (@CustomerID = 0 OR b.CustomerID = @CustomerID)
                        AND YEAR(b.[Date]) = @Year
                        AND MONTH(b.[Date]) = @Month
                    ORDER BY b.[Date] DESC;
                ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Month", month);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }


    }
}
