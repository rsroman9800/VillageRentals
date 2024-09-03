using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentals.Data
{
    public class RentalEquipment
    {
        public int EquipmentId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float DailyRate { get; set; }

        public RentalEquipment()
        {
            
        }

        public RentalEquipment(int equipmentId, int categoryId, string name, string description, float dailyRate)
        {
            EquipmentId = equipmentId;
            CategoryId = categoryId;
            Name = name;
            Description = description;
            DailyRate = dailyRate;
        }

        public override string ToString()
        {
            return $"{EquipmentId}, {CategoryId}, {Name}, {Description}, ${DailyRate}";
        }
    }

}
