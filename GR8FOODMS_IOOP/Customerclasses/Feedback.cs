using System;

namespace Gr8Food.Classes
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public string Text { get; set; }
        public int ManagerID { get; set; }
        public string Response { get; set; }
        public DateTime ResponseDate { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }

        public Feedback() { }

        public Feedback(int feedbackID, string text, int managerID,
                        string response, DateTime responseDate,
                        int orderID, int customerID)
        {
            FeedbackID = feedbackID;
            Text = text;
            ManagerID = managerID;
            Response = response;
            ResponseDate = responseDate;
            OrderID = orderID;
            CustomerID = customerID;
        }
    }
}