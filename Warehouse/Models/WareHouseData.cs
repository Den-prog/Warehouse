using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Warehouse.Models
{
    public class WarehouseData
    {
        public List<Product> Products { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}
