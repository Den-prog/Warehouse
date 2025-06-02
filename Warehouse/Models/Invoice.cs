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
        private static int _nextId = 1;
        public int Id { get;  set; }
       /* public Invoice()
        {
           Id = _nextId++;
           

        }*/
        public void AssignId()
        {
            Id = _nextId++;
        }
        public static void UpdateNextId(IEnumerable<Invoice> invoices)
        {
            if (invoices == null || !invoices.Any())
            {
                _nextId = 1;
            }
            else
            {
                _nextId = invoices.Max(i => i.Id) + 1;
            }
        }
        public DateTime Date { get; set; }
        public BindingList<InvoiceItem> Items{ get; set; }
        public InvoiceType Type { get; set; }

       
    }
    public class InvoiceItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalValue { get; set; }


    }

    public enum InvoiceType
    {
        Income,
        Outcome
    }
}
