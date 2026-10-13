using System;
using System.Data.SqlClient;
using Gr8Food.Classes;

namespace IOOP_Manager
{
    public partial class Feedback
    {
        private int _FeedbackID;
        private string _Text;
        private int? _ManagerID;
        private string _Response;
        private DateTime? _ResponseDate;
        private int? _OrderID;

        public int FeedbackID { get { return _FeedbackID; } }
        public string Text { get { return _Text; } }
        public int? ManagerID { get { return _ManagerID; } }
        public string Response { get { return _Response; } }
        public DateTime? ResponseDate { get { return _ResponseDate; } }
        public int? OrderID { get { return _OrderID; } }

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
        public Feedback(int id)
        {
            _FeedbackID = id;
        }

        // Constructor for adding new record
        public Feedback(int id, string text, int? managerId, string response, DateTime? responseDate, int? orderId)
        {
            _FeedbackID = id;
            _Text = text;
            _ManagerID = managerId;
            _Response = response;
            _ResponseDate = responseDate;
            _OrderID = orderId;
        }

        // Constructor for updating record
        public Feedback(int id, string text, int? managerId, string response, DateTime? responseDate, int? orderId, bool forUpdate)
        {
            _FeedbackID = id;
            _Text = text;
            _ManagerID = managerId;
            _Response = response;
            _ResponseDate = responseDate;
            _OrderID = orderId;
        }


        // Update Existing Feedback
        public void FeedbackResponse()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Feedback SET 
                            Text = @Text,
                            ManagerID = @ManagerID,
                            Response = @Response,
                            ResponseDate = @ResponseDate,
                            OrderID = @OrderID
                         WHERE FeedbackID = @FeedbackID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FeedbackID", _FeedbackID);
                cmd.Parameters.AddWithValue("@Text", _Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ManagerID", _ManagerID.HasValue ? _ManagerID.Value : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Response", _Response ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ResponseDate", _ResponseDate.HasValue ? _ResponseDate.Value : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@OrderID", _OrderID.HasValue ? _OrderID.Value : (object)DBNull.Value);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }

}
