using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class Product
    {
        public string Name {  get; set; }
        public string Unit { get; set; }
        public decimal PricePerUnit { get; set; }
        
        public int Quantity {  get; set; }
        public DateTime LastDeliveryDate { get; set; }

        public decimal TotalValue => PricePerUnit * Quantity;

        public override string ToString()
        {
            return Name;
        }
    }
}
