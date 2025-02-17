using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management_COnsole_App
{
    internal class OnlineOrder : Order
    {
        private string deliveryAddress;

        public OnlineOrder(int orderId, string customerName, string deliveryAddress)
            : base(orderId, customerName)
        {
            this.deliveryAddress = deliveryAddress;
        }

        // Implementing abstract method
        public override void ProcessOrder()
        {
            Console.WriteLine($"Processing online order {OrderId} for {CustomerName}. Delivering to {deliveryAddress}.");
        }

        // Overriding method for polymorphism
        public override void PrintReceipt()
        {
            base.PrintReceipt();
            Console.WriteLine($"Delivery Address: {deliveryAddress}\n");
        }
    }
}
