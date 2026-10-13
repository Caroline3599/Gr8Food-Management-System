using System;

namespace Gr8Food.Classes
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int EWallet { get; set; }

        public Customer() { }

        public Customer(int customerID, int userID, string name, string email,
                        string phone, DateTime birthday, string address,
                        string password, int eWallet)
        {
            CustomerID = customerID;
            UserID = userID;
            Name = name;
            Email = email;
            Phone = phone;
            Birthday = birthday;
            Address = address;
            Password = password;
            EWallet = eWallet;
        }
    }
}