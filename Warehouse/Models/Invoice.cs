using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    // Клас Invoice описує накладну, яка містить інформацію про дату, тип, список товарів та унікальний ідентифікатор.
    public class Invoice
    {
        
        private static int _nextId = 1;
        public int Id { get;  set; }

        // Метод призначає накладній унікальний ідентифікатор.
        public void AssignId()
        {
            Id = _nextId++;
        }
        // Метод оновлює значення наступного ідентифікатора на основі існуючих накладних.
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

    //Клас InvoiceItem описує у накладній товар, його кількість та загальну вартість.
    
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
