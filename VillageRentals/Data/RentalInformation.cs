using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentals.Data
{
    public class RentalInformation
    {
        public int RentalId { get; set; }
        public string Date { get; set; }
        public int CustomerId { get; set; }
        public int EquipmentId { get; set; }
        public string RentalDate { get; set; }
        public string ReturnDate { get; set; }
        public float Cost { get; set; }

        public RentalInformation()
        {
            
        }

        public RentalInformation(int rentalId, string date, int customerId, int equipmentId, string rentalDate, string returnDate, float cost)
        {
            RentalId = rentalId;
            Date = date;
            CustomerId = customerId;
            EquipmentId = equipmentId;
            RentalDate = rentalDate;
            ReturnDate = returnDate;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"{RentalId}, {Date}, {CustomerId}, {EquipmentId}, {RentalDate}, {ReturnDate}, {Cost}";
        }
    }
}
