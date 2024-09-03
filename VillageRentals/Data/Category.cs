using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentals.Data
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public Category()
        {
            
        }

        public Category(int categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }

        public override string ToString()
        {
            return $"{CategoryId} - {Name}";
        }
    }


}
