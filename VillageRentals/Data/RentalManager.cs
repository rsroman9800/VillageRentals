using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentals.Data
{
    public class RentalManager
    {
        public string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Resources\\Res\\rental_info.csv");
        public List<RentalInformation> rentals = new List<RentalInformation>();
        public bool rentalsLoaded = false;

        public RentalManager()
        {
            this.rentals = new List<RentalInformation>(); // Initialize the list
            populateRentals(); // Load the data
        }

        public void populateRentals()
        {
            if (rentalsLoaded) // If the data is already loaded, return
            {
                return;
            }

            foreach(string line in File.ReadAllLines(filePath)) // Read each line in the file
            {
                string[] parts = line.Split(',');
                RentalInformation rental = new RentalInformation(int.Parse(parts[0]), parts[1], int.Parse(parts[2]), int.Parse(parts[3]), parts[4], parts[5], float.Parse(parts[6]));
                rentals.Add(rental);
            }

            rentalsLoaded = true; // Set the flag to true
        }

        public void addRental(RentalInformation rental)
        {
            rentals.Add(rental); // Add the rental to the list
            File.AppendAllText(filePath, $"{rental.RentalId},{rental.Date},{rental.CustomerId},{rental.EquipmentId},{rental.RentalDate},{rental.ReturnDate},{rental.Cost}\n"); // Append the new rental to the file
        }

    }
}
