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
        /*public InvoiceDetailsForm(Invoice invoice)
        {
            InitializeComponent();

            // Заголовок форми
            this.Text = $"Деталі накладної №{invoice.Id} ({invoice.Type})";

          

            // Налаштування DataGridView для елементів накладної
            dgvInvoiceItems.AutoGenerateColumns = false; // Ми будемо додавати стовпці вручну
            dgvInvoiceItems.ReadOnly = true;
            dgvInvoiceItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoiceItems.MultiSelect = false;

            // Додаємо стовпці вручну для кращого відображення
            // Назва товару
            DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn();
            productNameColumn.DataPropertyName = "Product.Name"; // Звертаємося до властивості Product.Name
            productNameColumn.HeaderText = "Назва товару";
            productNameColumn.Name = "ProductName";
            dgvInvoiceItems.Columns.Add(productNameColumn);

            // Одиниця виміру товару
            DataGridViewTextBoxColumn productUnitColumn = new DataGridViewTextBoxColumn();
            productUnitColumn.DataPropertyName = "Product.Unit"; // Звертаємося до властивості Product.Unit
            productUnitColumn.HeaderText = "Од. виміру";
            productUnitColumn.Name = "ProductUnit";
            dgvInvoiceItems.Columns.Add(productUnitColumn);

            // Кількість
            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.DataPropertyName = "Quantity";
            quantityColumn.HeaderText = "Кількість";
            quantityColumn.Name = "Quantity";
            dgvInvoiceItems.Columns.Add(quantityColumn);

            // Важливо: Прив'язуємо DataGridView до списку Invoice.Items
            dgvInvoiceItems.DataSource = invoice.Items;
        }

        // Цей обробник потрібен для того, щоб DataGridView правильно відображав вкладені властивості, як "Product.Name"
        private void dgvInvoiceItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var item = dgvInvoiceItems.Rows[e.RowIndex].DataBoundItem as InvoiceItem;
                if (item == null) return;

                // Обробка стовпця "Назва товару"
                if (dgvInvoiceItems.Columns[e.ColumnIndex].Name == "ProductName")
                {
                    e.Value = item.Product?.Name; // Використовуємо ?. для безпечного доступу
                    e.FormattingApplied = true;
                }
                // Обробка стовпця "Од. виміру"
                else if (dgvInvoiceItems.Columns[e.ColumnIndex].Name == "ProductUnit")
                {
                    e.Value = item.Product?.Unit;
                    e.FormattingApplied = true;
                }
            }
        }*/
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

            var itemsForGrid = invoice.Items.Select(item => new
            {
                ProductName = item.Product.Name,
                ProductUnit = item.Product.Unit,
                Quantity = item.Quantity,
                TotalUniy = item.Product.TotalValue
            }).ToList();

            dgvInvoiceItems.DataSource = null;
            dgvInvoiceItems.DataSource = itemsForGrid;

        }
    }
}