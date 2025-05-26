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
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;


namespace Warehouse.Forms
{
    public partial class MainForm : Form
    {
        private List<Product> allProducts;
        //private List<Invoice> invoices;

        private List<Invoice> invoices = new List<Invoice>();

        private AllInvoicesForm allInvoicesForm;


        public MainForm()
        {
            InitializeComponent();
            LoadTestData();
            UpdateProductGridHeaders();
            LoadInvoicesFromFile();
        }
        private void LoadTestData()
        {
            allProducts = TestDataGenerator.GetSampleProducts();
            dgvInvoices.DataSource = allProducts;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.MultiSelect = false;
            dgvInvoices.ReadOnly = true;


        }
        public void RefreshProductGrid()
        {
            dgvInvoices.DataSource = null;
            dgvInvoices.DataSource = allProducts;
            UpdateProductGridHeaders();


        }


        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            //InvoiceForm invoiceForm = new InvoiceForm(allProducts);
            //invoiceForm.ShowDialog();
            //var invoiceForm = new InvoiceForm(allProducts);
            //invoiceForm.ShowDialog();
            ////invoiceForm.FormClosing += (s, args) => RefreshProductGrid();
            ////invoiceForm.ShowDialog();
            //RefreshProductGrid();
            //UpdateProductGridHeaders();
            using (var invoiceForm = new InvoiceForm(allProducts))
            {
                if (invoiceForm.ShowDialog() == DialogResult.OK)
                {
                    if (invoiceForm.SavedInvoice != null)
                    {
                        invoices.Add(invoiceForm.SavedInvoice);
                        if (allInvoicesForm != null && !allInvoicesForm.IsDisposed)
                        {
                            allInvoicesForm.UpdateInvoices(invoices);
                        }
                    }
                    RefreshProductGrid();
                }
            }


        }

        private void Inventory_Click(object sender, EventArgs e)
        {

        }

        private void LoadProoductsFormFile()
        {
            if (File.Exists("products.json"))
            {
                string json = File.ReadAllText("products.json");
                allProducts = JsonSerializer.Deserialize<List<Product>>(json);

                dgvInvoices.DataSource = null;
                dgvInvoices.DataSource = allProducts;
                UpdateProductGridHeaders();
            }
        }
        private void SaveProductsToFile()
        {
            string json = JsonSerializer.Serialize(allProducts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("products.json", json);
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveProductsToFile();
                MessageBox.Show("Склад збережено");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження: " + ex.Message);
            }
        }

        private void btnLoadFormFile_Click(object sender, EventArgs e)
        {
            try
            {
                LoadProoductsFormFile();
                MessageBox.Show("Склад завантажено!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантеження: " + ex.Message);
            }
        }



        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void створитиНакладнуToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void створитиНакладнуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /* //var invoiceForm = new InvoiceForm(allProducts);
             //invoiceForm.ShowDialog();
             //RefreshProductGrid();
             //UpdateProductGridHeaders();
             using (var invoiceForm = new InvoiceForm(allProducts))
             {
                 if (invoiceForm.ShowDialog() == DialogResult.OK)
                 {
                     RefreshProductGrid();
                     UpdateProductGridHeaders();
                 }
             }*/
            using (var invoiceForm = new InvoiceForm(allProducts))
            {
                if (invoiceForm.ShowDialog() == DialogResult.OK)
                {
                    if (invoiceForm.SavedInvoice != null)
                    {
                        invoices.Add(invoiceForm.SavedInvoice);
                        if (allInvoicesForm != null && !allInvoicesForm.IsDisposed)
                        {
                            allInvoicesForm.UpdateInvoices(invoices);
                        }
                    }
                    RefreshProductGrid();
                }
            }
        }

        private void зберегтиСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveProductsToFile();
                MessageBox.Show("Склад збережено");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження: " + ex.Message);
            }

        }

        private void завантажитиСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadProoductsFormFile();
                MessageBox.Show("Склад завантажено!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантеження: " + ex.Message);
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateProductGridHeaders()
        {
            if (dgvInvoices.Columns.Count == 0) return;

            dgvInvoices.Columns["Name"].HeaderText = "Назва";
            dgvInvoices.Columns["Unit"].HeaderText = "Одиниця виміру";
            dgvInvoices.Columns["PricePerUnit"].HeaderText = "Ціна за одиницю";
            dgvInvoices.Columns["Quantity"].HeaderText = "Кількість";
            dgvInvoices.Columns["LastDeliveryDate"].HeaderText = "Дата останнього завезення";

        }

        private void bnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm2 = new InventoryForm();
            inventoryForm2.ShowDialog();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*// Перевіряємо, що клацнули на дійсному рядку (не на заголовку стовпця)
            if (e.RowIndex >= 0)
            {
                // Отримуємо обрану накладну з DataGridView
                Invoice selectedInvoice = dgvInvoices.Rows[e.RowIndex].DataBoundItem as Invoice;

                if (selectedInvoice != null)
                {
                    // Створюємо нову форму деталей і передаємо їй обрану накладну
                    InvoiceDetailsForm detailsForm = new InvoiceDetailsForm(selectedInvoice);
                    detailsForm.ShowDialog(); // Відкриваємо форму як діалогове вікно
                }
            }*/
        }

        private void прибутокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (var invoiceForm = new InvoiceForm(allProducts))
            //{
            //    if (invoiceForm.ShowDialog() == DialogResult.OK)
            //    {
            //        RefreshProductGrid();
            //        UpdateProductGridHeaders();
            //    }
            //}
            using (var invoiceForm = new InvoiceForm(allProducts))
            {
                if (invoiceForm.ShowDialog() == DialogResult.OK)
                {
                    if (invoiceForm.SavedInvoice != null)
                    {
                        invoices.Add(invoiceForm.SavedInvoice);
                        if (allInvoicesForm != null && !allInvoicesForm.IsDisposed)
                        {
                            allInvoicesForm.UpdateInvoices(invoices);
                        }
                    }
                    RefreshProductGrid();
                }
            }
        }

        private void всіНакладніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (allInvoicesForm == null || allInvoicesForm.IsDisposed)
            {
                allInvoicesForm = new AllInvoicesForm(invoices);
                allInvoicesForm.Show();
            }
            else
            {
                allInvoicesForm.UpdateInvoices(invoices);
                allInvoicesForm.BringToFront(); // піднімає форму на передній план
            }

        }


        private void LoadInvoicesFromFile()
        {
            if (File.Exists("invoices.json"))
            {
                var json = File.ReadAllText("invoices.json");
                invoices = JsonSerializer.Deserialize<List<Invoice>>(json) ?? new List<Invoice>();
            }
        }

        private void документиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
