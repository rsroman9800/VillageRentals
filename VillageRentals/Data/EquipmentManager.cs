using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentals.Data
{
    public class EquipmentManager
    {
        public string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Resources\\Res\\rental_equipment.csv");
        public List<RentalEquipment> Equipment { get; set; }
        public bool equipmentLoaded = false;

        public EquipmentManager()
        {
            this.Equipment = new List<RentalEquipment>(); // Initialize the list
            populateEquipment(); // Load the data
        }

        public List <RentalEquipment> populateEquipment()
        {
            if (equipmentLoaded) // If the data is already loaded, return
            {
                return Equipment;
            }

            Equipment = new List<RentalEquipment>();

            foreach(string line in File.ReadAllLines(filePath)) // Read each line in the file
            {
                string[] parts = line.Split(',');
                RentalEquipment equipment = new RentalEquipment(int.Parse(parts[0]), int.Parse(parts[1]), parts[2], parts[3], float.Parse(parts[4]));
                Equipment.Add(equipment);
            }

            equipmentLoaded = true; // Set the flag to true
            return Equipment;
        }

        public void addEquipment(RentalEquipment equipment)
        {
            Equipment.Add(equipment); // Add the equipment to the list
            File.AppendAllText(filePath, $"{equipment.EquipmentId},{equipment.CategoryId},{equipment.Name},{equipment.Description},{equipment.DailyRate}\n"); // Append the new equipment to the file
        }

        public void deleteEquipment(int equipmentId)
        {
            Equipment.RemoveAll(e => e.EquipmentId == equipmentId); // Remove the equipment from the list
            File.WriteAllLines(filePath, Equipment.Select(e => $"{e.EquipmentId},{e.CategoryId},{e.Name},{e.Description},{e.DailyRate}")); // Write the updated list to the file
        }

        public RentalEquipment getEquipmentById(int equipmentId)
        {
            return Equipment.Find(e => e.EquipmentId == equipmentId); // Find the equipment by ID
        }

        public void DisplayEquipment()
        {
            foreach (RentalEquipment equipment in Equipment)
            {
                Console.WriteLine(equipment.ToString()); // Print the equipment
            }
        }
    }
}
