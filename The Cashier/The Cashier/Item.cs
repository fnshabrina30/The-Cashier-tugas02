using System;
using System.Collections.Generic;
using System.Text;

namespace The_Cashier
{
    class Item
    {
        private int id;
        public string title { get; set; }
        public int quality { get; set; }
        public double price { get; set; }
        public double subtotal { get; set; }
        private string type;

        public Item(int id, string title, int quality, double price, double subtotal, string type)
        {
            this.id = id;
            this.title = title;
            this.quality = quality;
            this.price = price;
            this.subtotal = subtotal;
            this.type = type;
        }
        public string getTitle()
        {
            return title;
        }
        public int getQuantity()
        {
            return getQuantity;
        }
        public string getType()
        {
            return type;
        }
        public double getPrice()
        {
            return price;
        }
        public double getSubTotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }
    }
}
