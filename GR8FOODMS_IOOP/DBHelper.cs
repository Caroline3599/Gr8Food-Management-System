using System.Configuration;
using System.Data.SqlClient;

namespace Gr8Food.Classes
{
    public class DBHelper
    {
        public IOOP_Manager.Feedback Feedback
        {
            get => default;
            set
            {
            }
        }

        public IOOP_Manager.ManagerWalletReportRepository ManagerWalletReportRepository
        {
            get => default;
            set
            {
            }
        }

        public IOOP_Manager.Manager Manager
        {
            get => default;
            set
            {
            }
        }

        public System_Admin_Assignment.Admin Admin
        {
            get => default;
            set
            {
            }
        }

        public System_Admin_Assignment.Chef Chef
        {
            get => default;
            set
            {
            }
        }

        public System_Admin_Assignment.Menu Menu
        {
            get => default;
            set
            {
            }
        }

        public System_Admin_Assignment.Order Order
        {
            get => default;
            set
            {
            }
        }

        public System_Admin_Assignment.Customer Customer
        {
            get => default;
            set
            {
            }
        }

        public System_Admin_Assignment.Manager Manager1
        {
            get => default;
            set
            {
            }
        }

        public SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["Gr8FoodDB"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}