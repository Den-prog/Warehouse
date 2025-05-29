using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            lblInvoiceType.Text = $"Тип: {invoice.Type}";

            //var itemsForGrid = invoice.Items.Select(item => new
            //{
            //    ProductName = item.Product.Name,
            //    ProductUnit = item.Product.Unit,
            //    Quantity = item.Quantity,
            //    TotalUnit = item.Product.TotalValue
            //}).ToList();

            //dgvInvoiceItems.DataSource = null;
            //dgvInvoiceItems.DataSource = itemsForGrid;
            //dgvInvoiceItems.DataSource = null;
            //dgvInvoiceItems.DataSource = invoice.Items.Select(i => i.Product).ToList();
            var itemsForGrid = invoice.Items.Select(item => new
            {
                Назва = item.Product.Name,
                Одиниця = item.Product.Unit,
                Кількість = item.Quantity,
                Ціна = item.Product.PricePerUnit,
                Сума = item.Quantity * item.Product.PricePerUnit
            }).ToList();

            dgvInvoiceItems.DataSource = null;
            dgvInvoiceItems.DataSource = itemsForGrid;



        }
    }
}