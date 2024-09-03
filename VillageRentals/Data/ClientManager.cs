using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentals.Data
{
    public class ClientManager
    {
        public string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Resources\\Res\\customer_info.csv");
        public List<CustomerInformation> customers = new List<CustomerInformation>();
        public bool customersLoaded = false;

        public ClientManager()
        {
            this.customers = new List<CustomerInformation>(); // Initialize the list
            populateCustomers(); // Load the data
        }

        public List <CustomerInformation> populateCustomers()
        {
            if (customersLoaded) // If the data is already loaded, return
            {
                return customers;
            }

            customers = new List<CustomerInformation>();

            foreach(string line in File.ReadAllLines(filePath)) // Read each line in the file
            {
                string[] parts = line.Split(',');
                CustomerInformation customer = new CustomerInformation(int.Parse(parts[0]), parts[1], parts[2], parts[3], parts[4]);
                customers.Add(customer);
            }

            customersLoaded = true; // Set the flag to true
            return customers;
        }

        public void addCustomer(CustomerInformation customer)
        {
            customers.Add(customer); // Add the customer to the list
            File.AppendAllText(filePath, $"{customer.CustomerId},{customer.LastName},{customer.FirstName},{customer.PhoneNumber},{customer.Email}\n"); // Append the new customer to the file
        }

        public void DisplayCustomers()
        {
            foreach (CustomerInformation customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }  
    }
}
