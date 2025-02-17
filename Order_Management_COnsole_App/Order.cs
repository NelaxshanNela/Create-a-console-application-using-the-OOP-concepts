using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management_COnsole_App
{
    abstract class Order
    {
        private int orderId;
        private string customerName;

        // Encapsulation: Using properties
        public int OrderId { get { return orderId; } }
        public string CustomerName { get { return customerName; } }

        // Constructor
        public Order(int orderId, string customerName)
        {
            this.orderId = orderId;
            this.customerName = customerName;
        }

        // Abstract method (to be implemented by derived classes)
        public abstract void ProcessOrder();

        // Virtual method for polymorphism
        public virtual void PrintReceipt()
        {
            Console.WriteLine("\nOrder Receipt:");
            Console.WriteLine($"Order ID: {OrderId}\nCustomer: {CustomerName}");
        }
    }
}
