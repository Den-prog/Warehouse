using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public BindingList<InvoiceItem> Items{ get; set; }
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
