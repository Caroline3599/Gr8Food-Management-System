using System;

namespace Ioop_Group_Assignment_Cheif
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string OrderRemarks { get; set; }
        public int Quantity { get; set; }

        public Order() { }

        public Order(int orderID, int customerID, DateTime orderDate, string orderStatus, string orderRemarks, int quantity)
        {
            OrderID = orderID;
            CustomerID = customerID;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
            OrderRemarks = orderRemarks;
            Quantity = quantity;
        }
    }
}
