using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DatabaseHelper = Gr8Food.Classes.DBHelper;

namespace System_Admin_Assignment
{
    public class Manager
    {
        private int _ManagerID;
        private int _UserID;
        private string _Name;
        private string _Password;
        private string _Email;
        private string _Phone;
        private object _Birthday;
        private object _Address;


        public int ManagerID
        {
            get { return _ManagerID; }
        }

        public int UserID
        {
            get { return _UserID; }
        }

        public string ManagerName
        {
            get { return _Name; }
        }

        public string Email
        {
            get { return _Email; }
        }

        public string Phone
        {
            get { return _Phone; }
        }

        public object Birthday
        {
            get { return _Birthday; }
        }

        public object Address
        {
            get { return _Address; }
        }

        public string Password
        {
            get { return _Password; }
        }

        // Deletion (Only requires ID)
        public Manager(int id)
        {
            _ManagerID = id;
        }

        // Adding New Records
        public Manager(int userId, string name, string email, string phone, object birthday, string address, string password)
        {
            _UserID = userId;
            _Name = name;
            _Email = email;
            _Phone = phone.Trim();
            _Birthday = birthday;
            _Address = string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address.Trim();
            _Password = password;
        }

        //  Updating Records
        public Manager(int managerId, int userId, string name, string email, string phone, object birthday, string address, string password)
        {
            _ManagerID = managerId;
            _UserID = userId;
            _Name = name;
            _Email = email;
            _Phone = phone.Trim();
            _Birthday = birthday;
            _Address = string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address.Trim();
            _Password = password;
        }

        //Read all manager
        public DataTable ReadAllManagers()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM [dbo].[Manager];";
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
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving all managers: " + ex.Message);
            }
            return dt;
        }

        // Read manager based on ID
        public Manager ReadManager()
        {
            string query = "SELECT * FROM [dbo].[Manager] WHERE [ManagerID] = @ManagerID;";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Accesses the current instance's internal field variable directly instead of an external parameter
                        cmd.Parameters.AddWithValue("@ManagerID", this._ManagerID);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Manager(
                                    Convert.ToInt32(reader["ManagerID"]),
                                    Convert.ToInt32(reader["UserID"]),
                                    reader["Name"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Phone"].ToString(),
                                    reader["Birthday"],
                                    reader["Address"].ToString(),
                                    reader["Password"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading manager record: " + ex.Message);
            }
            return null; // Record not found
        }

        // Add New Manager
        public void AddManager()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // ManagerID calculation
                    int nextManagerId = 1;
                    string calcQuery = "SELECT ISNULL(MAX(ManagerID), 0) + 1 FROM [dbo].[Manager];";
                    using (SqlCommand cmdCalc = new SqlCommand(calcQuery, conn))
                    {
                        nextManagerId = (int)cmdCalc.ExecuteScalar();
                    }

                    string query = @"
                        SET IDENTITY_INSERT [dbo].[Manager] ON;
                        INSERT INTO [dbo].[Manager] ([ManagerID], [UserID], [Name], [Email], [Phone], [Birthday], [Address], [Password]) 
                        VALUES (@ManagerID, @UserID, @Name, @Email, @Phone, @Birthday, @Address, @Password);
                        SET IDENTITY_INSERT [dbo].[Manager] OFF;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ManagerID", nextManagerId);
                        cmd.Parameters.AddWithValue("@UserID", _UserID);
                        cmd.Parameters.AddWithValue("@Name", _Name);
                        cmd.Parameters.AddWithValue("@Email", _Email);
                        cmd.Parameters.AddWithValue("@Phone", _Phone);
                        cmd.Parameters.AddWithValue("@Birthday", _Birthday);
                        cmd.Parameters.AddWithValue("@Address", _Address);
                        cmd.Parameters.AddWithValue("@Password", _Password);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding manager record: " + ex.Message);
            }
        }

        // Update Existing Manager Data
        public void UpdateManager()
        {
            string query = @"UPDATE [dbo].[Manager] SET 
                                [UserID] = @UserID,
                                [Name] = @Name,
                                [Email] = @Email,
                                [Phone] = @Phone,
                                [Birthday] = @Birthday,
                                [Address] = @Address,
                                [Password] = @Password 
                             WHERE [ManagerID] = @ManagerID";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ManagerID", _ManagerID);
                        cmd.Parameters.AddWithValue("@UserID", _UserID);
                        cmd.Parameters.AddWithValue("@Name", _Name);
                        cmd.Parameters.AddWithValue("@Email", _Email);
                        cmd.Parameters.AddWithValue("@Phone", _Phone);
                        cmd.Parameters.AddWithValue("@Birthday", _Birthday);
                        cmd.Parameters.AddWithValue("@Address", _Address);
                        cmd.Parameters.AddWithValue("@Password", _Password);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating manager record: " + ex.Message);
            }
        }

        // Delete Manager
        public void DeleteManager()
        {
            string query = "DELETE FROM [dbo].[Manager] WHERE [ManagerID] = @ManagerID";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ManagerID", _ManagerID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting manager record: " + ex.Message);
            }
        }
    }
}