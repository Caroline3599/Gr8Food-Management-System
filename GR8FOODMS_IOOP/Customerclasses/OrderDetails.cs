using System;

namespace Gr8Food.Classes
{
    public class OrderDetails
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int MenuID { get; set; }
        public int Quantity { get; set; }

        public OrderDetails() { }

        public OrderDetails(int orderDetailID, int orderID,
                            int menuID, int quantity)
        {
            OrderDetailID = orderDetailID;
            OrderID = orderID;
            MenuID = menuID;
            Quantity = quantity;
        }
    }
}