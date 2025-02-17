namespace Order_Management_COnsole_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Order onlineOrder = new OnlineOrder(101, "John Doe", "123 Main St");
            //Order inStoreOrder = new InStoreOrder(102, "Jane Smith", "Downtown Store");

            //onlineOrder.ProcessOrder();
            //onlineOrder.PrintReceipt();

            //inStoreOrder.ProcessOrder();
            //inStoreOrder.PrintReceipt();

            Console.WriteLine("Enter Order ID:");
            int orderId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Select Order Type (1 - Online, 2 - In-Store):");
            int orderType = int.Parse(Console.ReadLine());

            Order order;

            if (orderType == 1)
            {
                Console.WriteLine("Enter Delivery Address:");
                string deliveryAddress = Console.ReadLine();
                order = new OnlineOrder(orderId, customerName, deliveryAddress);
            }
            else
            {
                Console.WriteLine("Enter Pickup Store:");
                string pickupStore = Console.ReadLine();
                order = new InStoreOrder(orderId, customerName, pickupStore);
            }

            // Process the order and print receipt
            order.ProcessOrder();
            order.PrintReceipt();
        }
    }
}
