using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DatabaseHelper = Gr8Food.Classes.DBHelper;

namespace System_Admin_Assignment
{
    public class Chef
    {
        private int _ChefID;
        private int _UserID;
        private string _Name;
        private string _Password;
        private string _Email;
        private string _Phone;
        private object _Birthday;
        private object _Address;

        public int ChefID
        {
            get { return _ChefID; }
        }

        public int UserID
        {
            get { return _UserID; }
        }

        public string ChefName
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


        // For Deletion (Only requires ID)
        public Chef(int id)
        {
            _ChefID = id;
        }

        // For Adding New Records
        public Chef(int userId, string name, string email, string phone, object birthday, string address, string password)
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
        public Chef(int chefId, int userId, string name, string email, string phone, object birthday, string address, string password)
        {
            _ChefID = chefId;
            _UserID = userId;
            _Name = name;
            _Email = email;
            _Phone = phone.Trim();
            _Birthday = birthday;
            _Address = string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address.Trim();
            _Password = password;
        }

        //Read all chef
        public DataTable ReadAllChefs()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM [dbo].[Chef];";
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
                throw new Exception("Error retrieving all chefs: " + ex.Message);
            }
            return dt;
        }

        // Read Existing Chef Profile based on id
        public Chef ReadChef()
        {
            string query = "SELECT * FROM [dbo].[Chef] WHERE [ChefID] = @ChefID;";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Uses the current object instance's internal field identifier variable directly
                        cmd.Parameters.AddWithValue("@ChefID", this._ChefID);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Chef(
                                    Convert.ToInt32(reader["ChefID"]),
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
                throw new Exception("Error compiling chef lookup metrics: " + ex.Message);
            }
            return null;
        }

        // Add New Chef
        public void AddChef()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // ChefID Calculation
                    int nextChefId = 1;
                    string calcQuery = "SELECT ISNULL(MAX(ChefID), 0) + 1 FROM [dbo].[Chef];";
                    using (SqlCommand cmdCalc = new SqlCommand(calcQuery, conn))
                    {
                        nextChefId = (int)cmdCalc.ExecuteScalar();
                    }

                    string query = @"
                        SET IDENTITY_INSERT [dbo].[Chef] ON;
                        INSERT INTO [dbo].[Chef] ([ChefID], [UserID], [Name], [Password], [Email], [Phone], [Birthday], [Address]) 
                        VALUES (@ChefID, @UserID, @Name, @Password, @Email, @Phone, @Birthday, @Address);
                        SET IDENTITY_INSERT [dbo].[Chef] OFF;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ChefID", nextChefId);
                        cmd.Parameters.AddWithValue("@UserID", _UserID);
                        cmd.Parameters.AddWithValue("@Name", _Name);
                        cmd.Parameters.AddWithValue("@Password", _Password);
                        cmd.Parameters.AddWithValue("@Email", _Email);
                        cmd.Parameters.AddWithValue("@Phone", _Phone);
                        cmd.Parameters.AddWithValue("@Birthday", _Birthday);
                        cmd.Parameters.AddWithValue("@Address", _Address);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing chef profile insertion streams: " + ex.Message);
            }
        }

        // Update Existing Chef Data
        public void UpdateChef()
        {
            string query = @"UPDATE [dbo].[Chef] SET 
                                [UserID] = @UserID,
                                [Name] = @Name,
                                [Email] = @Email,
                                [Phone] = @Phone,
                                [Birthday] = @Birthday,
                                [Address] = @Address,
                                [Password] = @Password 
                             WHERE [ChefID] = @ChefID";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ChefID", _ChefID);
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
                throw new Exception("Error executing chef data modifications: " + ex.Message);
            }
        }

        // Delete Chef
        public void DeleteChef()
        {
            string query = "DELETE FROM [dbo].[Chef] WHERE [ChefID] = @ChefID";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ChefID", _ChefID);

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