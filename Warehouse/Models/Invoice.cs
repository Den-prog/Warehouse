using System;
using System.Collections.Generic;
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
        public List<InvoiceItem> Items { get; set; }
        public InvoiceType Type { get; set; }

       
    }
    public class InvoiceItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

       
    }
   /* public static class InvoiceManager
    {
        private static string filePath = "invoices.json";

        public static List<Invoice> LoadInvoices()
        {
            if (!File.Exists(filePath))
                return new List<Invoice>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Invoice>>(json);
        }

        public static void SaveInvoices(List<Invoice> invoices)
        {
            var json = JsonSerializer.Serialize(invoices, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }*/

    public enum InvoiceType
    {
        Income,
        Outcome
    }
}
