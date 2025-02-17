Order Management System (Console App)

📌 Overview

This is a simple Order Management System built in C# using Object-Oriented Programming (OOP) principles. The system allows users to create and process orders dynamically via console input.

🚀 Features

Encapsulation: Uses private fields with public properties.

Inheritance: Defines a base Order class and extends it into OnlineOrder and InStoreOrder.

Abstraction: Implements an abstract class with a mandatory method to be defined in derived classes.

Polymorphism: Overrides the PrintReceipt() method to provide different implementations.

User Input: Allows dynamic data entry instead of hardcoding values.

🛠️ Technologies Used

C# (.NET 6 or later recommended)

Console Application

📜 How to Run

Clone the Repository:

git clone https://github.com/your-username/order-management-system.git
cd order-management-system

Open the Project in Visual Studio or VS Code

Run the Application:

dotnet run

Follow the Console Prompts to enter order details dynamically.

📌 Example Usage

Enter Order ID:
1001
Enter Customer Name:
Alice
Select Order Type (1 - Online, 2 - In-Store):
1
Enter Delivery Address:
456 Elm Street

Output:

Processing online order 1001 for Alice. Delivering to 456 Elm Street.

Order Receipt:
Order ID: 1001
Customer: Alice
Delivery Address: 456 Elm Street

📜 License

This project is licensed under the MIT License.

🤝 Contributing

Pull requests are welcome! If you find any issues, feel free to submit them.
