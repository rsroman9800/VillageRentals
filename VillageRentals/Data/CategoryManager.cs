using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageRentals.Data
{
    public class CategoryManager
    {
        public string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Resources\\Res\\category_list.csv");
        public Dictionary<string, string> categories = new Dictionary<string, string>();
        public bool categoriesLoaded = false;

        public CategoryManager()
        {
            LoadCategories(); // Load the data
        }

        public void LoadCategories()
        {
            if (categoriesLoaded)
            {
                return; // If the data is already loaded, return
            }

            foreach (string line in File.ReadAllLines(filePath)) // Read each line in the file
            {
                string[] parts = line.Split(',');
                string categoryId = parts[0];
                string categoryName = parts[1];
                categories[categoryId] = categoryName;
            }

            categoriesLoaded = true;
        }

        public Dictionary<string, string> GetAllCategories() // Return all categories
        {
            return categories;
        }

    }
}
