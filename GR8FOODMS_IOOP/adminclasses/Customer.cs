using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DatabaseHelper = Gr8Food.Classes.DBHelper;

namespace System_Admin_Assignment
{
    public class Customer
    {
        private int _CustomerID;
        private int _UserID;
        private string _Name;
        private string _Password;
        private string _Email;
        private string _Phone;
        private object _Birthday;
        private object _Address;
        private int _EWallet;

        public int CustomerID
        {
            get { return _CustomerID; }
        }

        public int UserID
        {
            get { return _UserID; }
        }

        public string CustomerName
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

        public int EWallet
        {
            get { return _EWallet; }
        }

        // For Deletion (Only requires ID)
        public Customer(int id)
        {
            _CustomerID = id;
        }

        // For Adding New Records (Sets EWallet balance to 0 automatically)
        public Customer(int userId, string name, string email, string phone, object birthday, string address, string password)
        {
            _UserID = userId;
            _Name = name;
            _Email = email;
            _Phone = phone.Trim();
            _Birthday = birthday;
            _Address = string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address.Trim();
            _Password = password;
            _EWallet = 0; // Default wallet
        }

        // For Updating Records (Maintains active wallet balance parameter)
        public Customer(int customerId, int userId, string name, string email, string phone, object birthday, string address, string password, int eWallet)
        {
            _CustomerID = customerId;
            _UserID = userId;
            _Name = name;
            _Email = email;
            _Phone = phone.Trim();
            _Birthday = birthday;
            _Address = string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address.Trim();
            _Password = password;
            _EWallet = eWallet;
        }

        //Read all customers
        public DataTable ReadAllCustomers()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM [dbo].[Customer];";
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
                throw new Exception("Error retrieving all customers: " + ex.Message);
            }
            return dt;
        }

        //Read customer based on ID
        public Customer ReadCustomer()
        {
            string query = "SELECT * FROM [dbo].[Customer] WHERE [CustomerID] = @CustomerID;";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Accesses the current instance's internal variable directly instead of a standalone parameter
                        cmd.Parameters.AddWithValue("@CustomerID", this._CustomerID);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Customer(
                                    Convert.ToInt32(reader["CustomerID"]),
                                    Convert.ToInt32(reader["UserID"]),
                                    reader["Name"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Phone"].ToString(),
                                    reader["Birthday"],
                                    reader["Address"].ToString(),
                                    reader["Password"].ToString(),
                                    Convert.ToInt32(reader["EWallet"])
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading customer record: " + ex.Message);
            }
            return null; // Record not found
        }

        // Add New Customer
        public void AddCustomer()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // CustomerID Calculation
                    int nextCustomerId = 1;
                    string calcQuery = "SELECT ISNULL(MAX(CustomerID), 0) + 1 FROM [dbo].[Customer];";
                    using (SqlCommand cmdCalc = new SqlCommand(calcQuery, conn))
                    {
                        nextCustomerId = (int)cmdCalc.ExecuteScalar();
                    }

                    string query = @"
                        SET IDENTITY_INSERT [dbo].[Customer] ON;
                        INSERT INTO [dbo].[Customer] ([CustomerID], [UserID], [Name], [Email], [Phone], [Birthday], [Address], [Password], [EWallet]) 
                        VALUES (@CustomerID, @UserID, @Name, @Email, @Phone, @Birthday, @Address, @Password, @EWallet);
                        SET IDENTITY_INSERT [dbo].[Customer] OFF;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", nextCustomerId);
                        cmd.Parameters.AddWithValue("@UserID", _UserID);
                        cmd.Parameters.AddWithValue("@Name", _Name);
                        cmd.Parameters.AddWithValue("@Email", _Email);
                        cmd.Parameters.AddWithValue("@Phone", _Phone);
                        cmd.Parameters.AddWithValue("@Birthday", _Birthday);
                        cmd.Parameters.AddWithValue("@Address", _Address);
                        cmd.Parameters.AddWithValue("@Password", _Password);
                        cmd.Parameters.AddWithValue("@EWallet", _EWallet);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding customer record: " + ex.Message);
            }
        }

        // Update Existing Customer Data
        public void UpdateCustomer()
        {
            string query = @"UPDATE [dbo].[Customer] SET 
                                [UserID] = @UserID,
                                [Name] = @Name,
                                [Email] = @Email,
                                [Phone] = @Phone,
                                [Birthday] = @Birthday,
                                [Address] = @Address,
                                [Password] = @Password,
                                [EWallet] = @EWallet 
                             WHERE [CustomerID] = @CustomerID";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", _CustomerID);
                        cmd.Parameters.AddWithValue("@UserID", _UserID);
                        cmd.Parameters.AddWithValue("@Name", _Name);
                        cmd.Parameters.AddWithValue("@Email", _Email);
                        cmd.Parameters.AddWithValue("@Phone", _Phone);
                        cmd.Parameters.AddWithValue("@Birthday", _Birthday);
                        cmd.Parameters.AddWithValue("@Address", _Address);
                        cmd.Parameters.AddWithValue("@Password", _Password);
                        cmd.Parameters.AddWithValue("@EWallet", _EWallet);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating customer record: " + ex.Message);
            }
        }

        // Delete Customer
        public void DeleteCustomer()
        {
            string query = "DELETE FROM [dbo].[Customer] WHERE [CustomerID] = @CustomerID";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", _CustomerID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting customer record: " + ex.Message);
            }
        }

        public void UpdateCustomerForOwnProfile()
        {
            string query = @"UPDATE [dbo].[Customer] SET 
                        [UserID] = @UserID,
                        [Name] = @Name,
                        [Email] = @Email,
                        [Phone] = @Phone,
                        [Birthday] = @Birthday,
                        [Address] = @Address,
                        [Password] = @Password
                     WHERE [CustomerID] = @CustomerID";

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", _CustomerID);
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
                throw new Exception("Error updating customer own profile: " + ex.Message);
            }
        }
    }
}