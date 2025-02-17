using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management_COnsole_App
{
    internal class InStoreOrder : Order
    {
        private string pickupStore;

        public InStoreOrder(int orderId, string customerName, string pickupStore)
            : base(orderId, customerName)
        {
            this.pickupStore = pickupStore;
        }

        // Implementing abstract method
        public override void ProcessOrder()
        {
            Console.WriteLine($"Processing in-store order {OrderId} for {CustomerName}. Pickup at {pickupStore}.");
        }
    }
}
