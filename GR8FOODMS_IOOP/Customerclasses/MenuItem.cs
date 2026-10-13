using System;

namespace Gr8Food.Classes
{
    public class MenuItem
    {
        public int MenuID { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public int ChefID { get; set; }

        public MenuItem() { }

        public MenuItem(int menuID, string itemName, int price,
                        string category, string status, int chefID)
        {
            MenuID = menuID;
            ItemName = itemName;
            Price = price;
            Category = category;
            Status = status;
            ChefID = chefID;
        }
    }
}