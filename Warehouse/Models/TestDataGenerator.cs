using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    // Клас TestDataGenerator надає методи для генерації тестових даних для складу.
    public static class TestDataGenerator
    {
        // Метод повертає список зразків товарів для початкового наповнення складу.
        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
        {
            new Product { Name = "Молоко", Unit = "л", PricePerUnit = 28.50m, Quantity = 100, LastDeliveryDate = DateTime.Today.AddDays(-2) },
            new Product { Name = "Хліб", Unit = "шт", PricePerUnit = 15.00m, Quantity = 50, LastDeliveryDate = DateTime.Today.AddDays(-1) },
            new Product { Name = "Яблука", Unit = "кг", PricePerUnit = 32.40m, Quantity = 200, LastDeliveryDate = DateTime.Today.AddDays(-5) },
            new Product { Name = "Цукор", Unit = "кг", PricePerUnit = 40m, Quantity = 300, LastDeliveryDate = DateTime.Today.AddDays(-3) }
        };
        }

   
    }

}
