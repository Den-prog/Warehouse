using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Models;
namespace Warehouse.Forms
{
    public partial class InvoiceDetailsForm : Form
    {
       
        private Invoice invoice;

        public InvoiceDetailsForm(Invoice invoice)
        {
            InitializeComponent();
            this.invoice = invoice;
            DisplayInvoiceDetails();

        }

        private void DisplayInvoiceDetails()
        {
            lblInvoiceNumber.Text = $"Номер накладної: {invoice.Id}";
            lblInvoiceDate.Text = $"Дата: {invoice.Date.ToShortDateString()}";
            lblInvoiceType.Text = $"Тип: {(invoice.Type == InvoiceType.Income? "Прибуткова накладна" : "Витратна накладна")}";
            
           




            var itemsForGrid = invoice.Items.Select(item => new
            {
                Name = item.Product.Name,
                Unit = item.Product.Unit,
                PricePerUnit = item.Product.PricePerUnit,
                Quantity = item.Quantity,
                TotalValue = item.Product.PricePerUnit * item.Quantity
            }).ToList();

            dgvInvoiceItems.DataSource = null;
            dgvInvoiceItems.DataSource = itemsForGrid;
            UpdateProductGridHeaders();

            decimal totalValueInvoice = itemsForGrid.Sum(item => item.TotalValue);
            lblInvoiceSuma.Text = $"Сума: {totalValueInvoice:C2}";
        }
        private void UpdateProductGridHeaders()
        {
            dgvInvoiceItems.Columns["Name"].HeaderText = "Назва";
            dgvInvoiceItems.Columns["Unit"].HeaderText = "Одиниця виміру";
            dgvInvoiceItems.Columns["PricePerUnit"].HeaderText = "Ціна за одиницю";
            dgvInvoiceItems.Columns["Quantity"].HeaderText = "Кількість";
            dgvInvoiceItems.Columns["TotalValue"].HeaderText = "Загальна вартість";
        }
    }
}