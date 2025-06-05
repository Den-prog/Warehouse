using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Models;

namespace Warehouse.Forms
{
    //Клас InvoiceForm відповідає за створення та редагування накладних,
    //додавання товарів до накладної, а також за збереження змін у складі.
    public partial class InvoiceForm : Form
    {
        private List<Product> products;

        private List<Product> originalProducts;

        private List<InvoiceItem> currentItems = new List<InvoiceItem>();

        private bool isSaved = false;

        public Invoice SavedInvoice { get; private set; }

        
        // Метод ініціалізує форму, налаштовує елементи керування та завантажує список товарів.
        public InvoiceForm(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
           

            dgvProducts.DataSource = products;
          
            nudQuantity.Minimum = 1;
            nudQuantity.Maximum = 1000;

          
            comboBoxInvoiceType.Items.Add("Прибуткова накладна");
            comboBoxInvoiceType.Items.Add("Витратна накладна");
            comboBoxInvoiceType.SelectedIndex = 0; 

            originalProducts = products.Select(p => new Product
            {
                Name = p.Name,
                Unit = p.Unit,
                Quantity = p.Quantity,
                PricePerUnit = p.PricePerUnit,
                
            }).ToList();
            this.FormClosing += InvoiceForm_FormClosing;
            UpdateProductsGrid();
        }
        // Метод повертає тип накладної, обраний користувачем.
        private InvoiceType GetSelectedInvoiceType()
        {
            var selectedItem = comboBoxInvoiceType.SelectedItem?.ToString();
            return selectedItem == "Прибуткова накладна" ? InvoiceType.Income : InvoiceType.Outcome;
        }
        // Метод повертає вибраний у таблиці товар.
        private Product GetSelectedProduct()
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var name = dgvProducts.SelectedRows[0].Cells["Name"].Value as string;
                if (name != null)
                {
                    return products.FirstOrDefault(p => p.Name == name);
                }
            }
            return null;
        }

        // Метод додає вибраний товар до поточної накладної.
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProduct();
            var quantity = (int)nudQuantity.Value;
            var invoiceType = GetSelectedInvoiceType();
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
            var exisitingItem = currentItems.FirstOrDefault(i => i.Product.Name == selectedProduct.Name);
            if (exisitingItem != null)
            {
                exisitingItem.Quantity += quantity;
            }
            else
            {
                InvoiceItem newItem = new InvoiceItem
                {
                    Product = selectedProduct,
                    Quantity = quantity

                };
                currentItems.Add(newItem);
            }

            UpdateProductsGrid();

        }
        // Метод оновлює відображення таблиці товарів з урахуванням поточних змін.
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
            
            }).ToList();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = displayList;

            if(dgvProducts.Columns.Contains("PricePerUnit"))
            {
                DataGridViewColumn priceColumn = dgvProducts.Columns["PricePerUnit"];
                priceColumn.DefaultCellStyle.Format = "C2";
            }
       

            dgvProducts.Columns["Name"].HeaderText = "Назва";
            dgvProducts.Columns["Unit"].HeaderText = "Одиниця виміру";
            dgvProducts.Columns["PricePerUnit"].HeaderText = "Ціна за одиницю";
            dgvProducts.Columns["Quantity"].HeaderText = "Кількість";
           

            if (selectedName != null)
            {
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.Cells["Name"].Value as string == selectedName)
                    {
                        row.Selected = true;
                        dgvProducts.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }
        // Метод повертає кількість товару з урахуванням поточних змін у накладній.
        private int GetVirtualQuantity(Product product)
        {
            int delta = 0;
            var invoiceType = GetSelectedInvoiceType();
            foreach (var item in currentItems)
            {
                if (item.Product == product)
                {
                    if (invoiceType == InvoiceType.Income)
                        delta += item.Quantity;
                    else
                        delta -= item.Quantity;
                }
            }
            return product.Quantity + delta;
        }

        // Метод зберігає накладну, оновлює залишки товарів та закриває форму.
        private void SaveInvoice_Click(object sender, EventArgs e)
        {
            if (currentItems.Count <= 0)
            {

                MessageBox.Show("Накладна не містить товару.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var invoice = new Invoice
            {

                Date = DateTime.Now,
                Type = GetSelectedInvoiceType(),
                Items = new BindingList<InvoiceItem>(currentItems)
            };
            invoice.AssignId();



            foreach (var item in invoice.Items)
            {
                var product = products.FirstOrDefault(p => p.Name == item.Product.Name);
                if (invoice.Type == InvoiceType.Income)
                {
                    product.Quantity += item.Quantity;
                    
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

        }

        // Метод обробляє закриття форми, пропонуючи зберегти накладну, якщо є незбережені зміни.
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
                    if (result == DialogResult.Yes)
                    {
                       
                        if (currentItems.Count > 0)
                        {
                            SaveInvoice.PerformClick();
                            
                        }
                        else
                        {
                            MessageBox.Show("Накладна не містить товару.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Cancel = true;                         }
                    }
                    else if (result == DialogResult.No)
                    {
                        
                        RollbackChanges();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true; 
                    }
                }

            }
        }

        // Метод скасовує зміни у кількості та ціні товарів, повертаючи їх до початкового стану.
        private void RollbackChanges()
        {
            
            foreach (var original in originalProducts)
            {
                var current = products.FirstOrDefault(p => p.Name == original.Name);
                if (current != null)
                {
                    current.Quantity = original.Quantity;
                    current.PricePerUnit = original.PricePerUnit;
                    
                }
            }
        }

       
    }
}
