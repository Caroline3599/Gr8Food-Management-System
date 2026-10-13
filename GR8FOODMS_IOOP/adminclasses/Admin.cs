using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DatabaseHelper = Gr8Food.Classes.DBHelper;

namespace System_Admin_Assignment
{
    public class Admin
    {
        private int _AdminID;
        private int _UserID;
        private string _Name;
        private string _Password;
        private string _Email;
        private string _Phone;
        private object _Birthday;
        private object _Address;

        public int AdminID { get { return _AdminID; } }
        public int UserID { get { return _UserID; } }
        public string AdminName { get { return _Name; } }
        public string Email { get { return _Email; } }
        public string Phone { get { return _Phone; } }
        public object Birthday { get { return _Birthday; } }
        public object Address { get { return _Address; } }
        public string Password { get { return _Password; } }

        // For Deletion
        public Admin(int id)
        {
            _AdminID = id;
        }

        // For Adding New Records
        public Admin(int userId, string name, string email, string phone, object birthday, string address, string password)
        {
            _UserID = userId;
            _Name = name;
            _Email = email;
            _Phone = phone.Trim();
            _Birthday = birthday;
            _Address = string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address.Trim();
            _Password = password;
        }

        // For Updating Records
        public Admin(int adminId, int userId, string name, string email, string phone, object birthday, string address, string password)
        {
            _AdminID = adminId;
            _UserID = userId;
            _Name = name;
            _Email = email;
            _Phone = phone.Trim();
            _Birthday = birthday;
            _Address = string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address.Trim();
            _Password = password;
        }

        // Read All Admin
        public DataTable ReadAllAdmins()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM [dbo].[Admin];";
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
                throw new Exception("Error retrieving all admins: " + ex.Message);
            }
            return dt;
        }

        // Read Existing Admin Profile based on ID
        public Admin ReadAdmin()
        {
            string query = "SELECT * FROM [dbo].[Admin] WHERE [AdminID] = @AdminID;";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Accesses the current instance's internal field identifier directly
                        cmd.Parameters.AddWithValue("@AdminID", this._AdminID);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Admin(
                                    Convert.ToInt32(reader["AdminID"]),
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
                throw new Exception("Error compiling admin lookup metrics in domain framework layer: " + ex.Message);
            }
            return null; // Record not found
        }

        // Add New Admin Account
        public void AddAdmin()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // AdminID Auto-Increment Calculation
                    int nextAdminId = 1;
                    string calcQuery = "SELECT ISNULL(MAX(AdminID), 0) + 1 FROM [dbo].[Admin];";
                    using (SqlCommand cmdCalc = new SqlCommand(calcQuery, conn))
                    {
                        nextAdminId = (int)cmdCalc.ExecuteScalar();
                    }

                    string query = @"
                        SET IDENTITY_INSERT [dbo].[Admin] ON;
                        INSERT INTO [dbo].[Admin] ([AdminID], [UserID], [Name], [Password], [Email], [Phone], [Birthday], [Address]) 
                        VALUES (@AdminID, @UserID, @Name, @Password, @Email, @Phone, @Birthday, @Address);
                        SET IDENTITY_INSERT [dbo].[Admin] OFF;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AdminID", nextAdminId);
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
                throw new Exception("Error executing administrative profile insertion streams: " + ex.Message);
            }
        }

        // Update Existing Admin
        public void UpdateAdmin()
        {
            string query = @"UPDATE [dbo].[Admin] SET 
                                [UserID] = @UserID,
                                [Name] = @Name,
                                [Email] = @Email,
                                [Phone] = @Phone,
                                [Birthday] = @Birthday,
                                [Address] = @Address,
                                [Password] = @Password 
                             WHERE [AdminID] = @AdminID";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AdminID", _AdminID);
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
                throw new Exception("Error executing structural data modifications inside SQL table schemas: " + ex.Message);
            }
        }

        // Delete Admin Data
        public void DeleteAdmin()
        {
            string query = "DELETE FROM [dbo].[Admin] WHERE [AdminID] = @AdminID";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AdminID", _AdminID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing physical table purges from backend database maps: " + ex.Message);
            }
        }
    }
}