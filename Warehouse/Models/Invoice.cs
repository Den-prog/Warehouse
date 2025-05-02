using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class Invoice
    {
        public int InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public InvoiceType Type { get; set; }
    }
    public class InvoiceItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    public enum InvoiceType
    {
        Income,
        Outcome
    }
}
