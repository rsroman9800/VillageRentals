**Overview**
The Village Rentals Management System is designed to simplify the management of equipment rentals and customer interactions. The system allows for the efficient management of equipment, customers, and rental transactions, ensuring a smooth operation for rental businesses.

**Key Features**
Equipment Management: Add, remove, and view rental equipment.
Customer Management: Register and manage customer information.
Rental Management: Create and manage rental transactions, including the selection of rental dates and associated equipment.

**Project Structure**
Core Classes
- CustomerInformation: Represents a customer in the system with properties such as CustomerId, LastName, FirstName, PhoneNumber, and Email. This class is used to store and manage customer data.
- RentalEquipment: Represents a piece of equipment available for rent. It includes properties like EquipmentId, CategoryId, Name, Description, and DailyRate.
- RentalInformation: Stores information about rental transactions, including properties like RentalId, CustomerId, EquipmentId, RentalDate, ReturnDate, and Cost.
- Category: Represents the category of equipment, with properties like CategoryId and CategoryName.

Manager Classes
- ClientManager: Handles the addition, retrieval, and management of customer information in the system.
- EquipmentManager: Manages the inventory of rental equipment, including adding new equipment, removing equipment, and listing all available equipment.
- RentalManager: Manages rental transactions, including creating new rentals and associating them with customers and equipment.

Razor Pages
- ManageEquipment.razor
  - This page allows users to add, remove, and view rental equipment. The page interacts with the EquipmentManager class to perform CRUD (Create, Read, Update, Delete) operations on the equipment inventory.
    - Add New Equipment: Allows the user to input equipment details such as ID, category, name, description, and daily rate.
    - Remove Equipment: Allows the user to remove equipment by entering the equipment ID.
    - Equipment List: Displays all available equipment.

- ManageCustomer.razor
  - This page handles the addition and display of customers. It interacts with the ClientManager class to manage customer data. Proper validation ensures that all required fields are filled before a customer is added.
    - Add New Customer: Allows the user to input customer details such as ID, last name, first name, phone number, and email.
    - Display Customers: Lists all customers registered in the system.

- ManageRental.razor
  - This page manages the creation of rental transactions. Users can enter details such as rental and return dates, equipment IDs, and customer IDs. The page validates the input and interacts with the RentalManager class to store rental information.
  - Create Rental: Allows the user to input rental details, including customer ID, equipment ID, rental date, return date, and cost.
  - Display Rentals: Lists all rental transactions recorded in the system.

**Installation**
1. Clone the Repository:

bash
Copy code
git clone https://github.com/yourusername/village-rentals.git
cd village-rentals

2. Open the Project:

Open the solution file (.sln) in Visual Studio.

3. Build the Project:

Restore NuGet packages and build the solution.

4. Run the Application:

Set the desired startup project and run the application using Visual Studio's built-in IIS Express or another web server.

**Usage**
Use the web interface to manage equipment, customers, and rental transactions.
Add and remove items as needed, with built-in validation to ensure data integrity.
View detailed lists of equipment, customers, and rental transactions.

**Contributing**
Contributions are welcome! Please fork the repository and submit a pull request with your changes.
