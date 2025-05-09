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
    public partial class InvoiceForm : Form
    {
        private List<Product> products;

        public InvoiceForm(List<Product> products)
        {
            InitializeComponent();
            this.products = products;

            dgvProducts.DataSource = products;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;


           
            nudQuantity.Minimum = 1;
            nudQuantity.Maximum = 1000;

            comboBoxInvoiceType.Items.Add(InvoiceType.Income);
            comboBoxInvoiceType.Items.Add(InvoiceType.Outcome);
            comboBoxInvoiceType.SelectedIndex = 0;

        }

        private Product GetSelectedProduct()
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                return dgvProducts.SelectedRows[0].DataBoundItem as Product;
            }
            return null;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private List<InvoiceItem> currentItems = new List<InvoiceItem>();

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProduct();
            var quantity = (int)nudQuantity.Value;
            var invoiceType =(InvoiceType)comboBoxInvoiceType.SelectedItem;
            if(selectedProduct == null)
            {
                MessageBox.Show("Будь ласка, виберіть товар.");
                return;
            }
            if (invoiceType == InvoiceType.Outcome && selectedProduct.Quantity < quantity) {
                MessageBox.Show("Недостатньо товару на складі.");
                return;
            }

            InvoiceItem newItem = new InvoiceItem
            {
                Product = selectedProduct,
                Quantity = quantity

            };
            currentItems.Add(newItem);

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = currentItems;
            

            if (invoiceType == InvoiceType.Income)
            {
                selectedProduct.Quantity += quantity;
            }
            else if(invoiceType == InvoiceType.Outcome)
            {
                selectedProduct.Quantity -= quantity;
            }

        }


    }
}
