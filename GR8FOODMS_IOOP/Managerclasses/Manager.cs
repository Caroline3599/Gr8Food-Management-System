using Gr8Food.Classes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace IOOP_Manager
{


    public partial class Manager
    {
        private int _ManagerID;
        private int _UserID;
        private string _Name;
        private string _Email;
        private string _Phone;
        private DateTime? _Birthday;
        private string _Address;
        private string _Password;

        public int ManagerID { get { return _ManagerID; } }
        public int UserID { get { return _UserID; } }
        public string MName { get { return _Name; } }
        public string Email { get { return _Email; } }
        public string Phone { get { return _Phone; } }
        public DateTime? Birthday { get { return _Birthday; } }
        public string Address { get { return _Address; } }
        public string Password { get { return _Password; } }

        // Connection string
        private string connectionString
        {
            get
            {
                DBHelper db = new DBHelper();
                return db.GetConnection().ConnectionString;
            }
        }

        // Constructor for deletion
        public Manager(int id)
        {
            _ManagerID = id;
        }

        // Constructor for adding new record
        public Manager(int userId, string name, string email, string phone, DateTime? birthday, string address, string password)
        {
            _UserID = userId;
            _Name = name;
            _Email = email;
            _Phone = phone;
            _Birthday = birthday;
            _Address = address;
            _Password = password;
        }

        // Constructor for updating record
        public Manager(int id, int userId, string name, string email, string phone, DateTime? birthday, string address, string password)
        {
            _ManagerID = id;
            _UserID = userId;
            _Name = name;
            _Email = email;
            _Phone = phone;
            _Birthday = birthday;
            _Address = address;
            _Password = password;
        }

        // read data for home screen
        public DataTable ReadManagerData()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Manager WHERE ManagerID = @ManagerID";

            try
            {
                DBHelper db = new DBHelper();
                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // We use the object's internal variable directly instead of passing a parameter!
                        cmd.Parameters.AddWithValue("@ManagerID", this._ManagerID);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            conn.Open();
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading manager data instance matrix: " + ex.Message);
            }

            return dt;
        }

        // Update Existing Manager
        public bool UpdateManager()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Manager SET 
                            UserID = @UserID,
                            Name = @Name,
                            Email = @Email,
                            Phone = @Phone,
                            Birthday = @Birthday,
                            Address = @Address,
                            Password = @Password
                         WHERE ManagerID = @ManagerID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ManagerID", _ManagerID);
                cmd.Parameters.AddWithValue("@UserID", _UserID);
                cmd.Parameters.AddWithValue("@Name", _Name ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", _Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", _Phone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Birthday", _Birthday.HasValue ? _Birthday.Value : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", _Address ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Password", _Password);



                conn.Open();
                cmd.ExecuteNonQuery();

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;

            }
        }

    }

}
