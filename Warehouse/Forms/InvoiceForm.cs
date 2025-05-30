using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Models;

namespace Warehouse.Forms
{
    public partial class InvoiceForm : Form
    {
        private List<Product> products;

        private List<Invoice> allInvoices = new List<Invoice>();//empty

        private List<Product> originalProducts;

        private List<InvoiceItem> currentItems = new List<InvoiceItem>();

        private bool isSaved = false;

        public Invoice SavedInvoice { get; private set; }

        private void SaveInvoiceToFile(List<Invoice> invoice, string filePath)
        {
            string json = JsonSerializer.Serialize(invoice, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(filePath, json);
        }
        public InvoiceForm(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
            this.allInvoices = allInvoices;

            dgvProducts.DataSource = products;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;



            nudQuantity.Minimum = 1;
            nudQuantity.Maximum = 1000;

            comboBoxInvoiceType.Items.Add(InvoiceType.Income);
            comboBoxInvoiceType.Items.Add(InvoiceType.Outcome);
            comboBoxInvoiceType.SelectedIndex = 0;

            originalProducts = products.Select(p => new Product
            {
                Name = p.Name,
                Unit = p.Unit,
                Quantity = p.Quantity,
                PricePerUnit = p.PricePerUnit,
                LastDeliveryDate = DateTime.Now,
            }).ToList();
            this.FormClosing += InvoiceForm_FormClosing;
            UpdateProductsGrid();
        }

        private Product GetSelectedProduct()
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var name = dgvProducts.SelectedRows[0].Cells["Name"].Value as string;//Value.ToString() - поменял;
                if (name != null)
                {
                    return products.FirstOrDefault(p => p.Name == name);
                }
            }
            return null;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProduct();
            var quantity = (int)nudQuantity.Value;
            var invoiceType = (InvoiceType)comboBoxInvoiceType.SelectedItem;
            if (selectedProduct == null)
            {
                MessageBox.Show("Будь ласка, виберіть товар.");
                return;
            }
            if (invoiceType == InvoiceType.Outcome && selectedProduct.Quantity < quantity)
            {
                MessageBox.Show("Недостатньо товару на складі.");
                return;
            }

            InvoiceItem newItem = new InvoiceItem
            {
                Product = selectedProduct,
                Quantity = quantity

            };
            currentItems.Add(newItem);


            UpdateProductsGrid();


            /* if (invoiceType == InvoiceType.Income)
             {
                 selectedProduct.Quantity += quantity;
             }
             else if (invoiceType == InvoiceType.Outcome)
             {
                 selectedProduct.Quantity -= quantity;
             }*/


        }

        private void UpdateProductsGrid()
        {
            string selectedName = null;
            if (dgvProducts.SelectedRows.Count > 0)
            {
                selectedName = dgvProducts.SelectedRows[0].Cells["Name"].Value as string;
            }

            var displayList = products.Select(p => new
            {
                Name = p.Name,
                Unit = p.Unit,
                PricePerUnit = p.PricePerUnit,
                Quantity = GetVirtualQuantity(p),
                LastDeliveryDate = p.LastDeliveryDate
            }).ToList();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = displayList;

            if (selectedName != null)
            {
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.Cells["Name"].Value as string == selectedName)
                    {
                        row.Selected = true;
                        dgvProducts.CurrentCell = row.Cells[0]; // Встановлюємо курсор на першу клітинку вибраного рядка
                        break;
                    }
                }
            }
        }
        private int GetVirtualQuantity(Product product)
        {
            int delta = 0;
            foreach (var item in currentItems)
            {
                if (item.Product == product)
                {
                    if ((InvoiceType)comboBoxInvoiceType.SelectedItem == InvoiceType.Income)
                        delta += item.Quantity;
                    else
                        delta -= item.Quantity;
                }
            }
            return product.Quantity + delta;
        }
        

        private void SaveInvoice_Click(object sender, EventArgs e)
        {
            if (currentItems.Count <= 0)
            {

                MessageBox.Show("Накладна порожня");
                return;
            }

            var invoice = new Invoice
            {

                Date = DateTime.Now,
                Type = (InvoiceType)comboBoxInvoiceType.SelectedItem,
                Items = new BindingList<InvoiceItem>(currentItems)
            };



            foreach (var item in invoice.Items)
            {
                var product = products.FirstOrDefault(p => p.Name == item.Product.Name);
                if (invoice.Type == InvoiceType.Income)
                {
                    product.Quantity += item.Quantity;
                    product.LastDeliveryDate = invoice.Date;
                }
                else
                {
                    if (product.Quantity >= item.Quantity)
                        product.Quantity -= item.Quantity;
                    else
                    {
                        MessageBox.Show($"Недостатньо товару: {product.Name}");
                        return;
                    }
                }
            }



            SavedInvoice = invoice;
            DialogResult = DialogResult.OK;
            isSaved = true;
            Close();



            //var detailsForm = new InvoiceDetailsForm(SavedInvoice);
            //detailsForm.ShowDialog();


        }


        private void InvoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved && currentItems.Count > 0)
            {
                var result = MessageBox.Show(
                  "Ви не зберегли накладну. Зберегти перед виходом?",
                  "Підтвердження",
                  MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    SaveInvoice.PerformClick();
                    // форма закриється після збереження
                }
                else if (result == DialogResult.No)
                {
                    // Відкат змін 
                    RollbackChanges();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Не закривати форму
                }
            }
        }
        private void RollbackChanges()
        {
            // Відновлює початкові кількості
            foreach (var original in originalProducts)
            {
                var current = products.FirstOrDefault(p => p.Name == original.Name);
                if (current != null)
                {
                    current.Quantity = original.Quantity;
                    current.PricePerUnit = original.PricePerUnit;
                    current.LastDeliveryDate = original.LastDeliveryDate;
                }
            }
        }





        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var addProduct = new AddProductForm();
            if (addProduct.ShowDialog() == DialogResult.OK)
            {
                products.Add(addProduct.NewProduct);

                UpdateProductsGrid();

            }



        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть товар для видалення");
                return;
            }

            var selectedProduct = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (selectedProduct != null)
            {
                var confirm = MessageBox.Show($"Ви дійсно хочете видалити товар \"{selectedProduct.Name}\" ? ", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    products.Remove(selectedProduct);
                    UpdateProductsGrid();
                }
            }
        }

        private void додатиТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProduct = new AddProductForm();
            if (addProduct.ShowDialog() == DialogResult.OK)
            {
                products.Add(addProduct.NewProduct);

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;

            }



        }

        private void видалитиТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть товар для видалення");
                return;
            }

            var selectedProduct = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (selectedProduct != null)
            {
                var confirm = MessageBox.Show($"Ви дійсно хочете видалити товар \"{selectedProduct.Name}\" ? ", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    products.Remove(selectedProduct);
                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = products;
                }
            }

        }

        private void зберегтиНакладнуToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void зберегтиНакладнууФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var invoice = new Invoice
            {
                Date = DateTime.Now,
                Type = (InvoiceType)comboBoxInvoiceType.SelectedItem,
                Items = new BindingList<InvoiceItem>(currentItems)
            };
            allInvoices.Add(invoice);
            SaveInvoiceToFile(allInvoices, "invoices.json");
            MessageBox.Show("Накладна збережена у файл");
        }
    }
}
