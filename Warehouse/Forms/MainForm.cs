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


namespace Warehouse.Forms
{
    public partial class MainForm : Form
    {
        private List<Product> allProducts;
        //private List<Invoice> invoices = new List<Invoice>();




        public MainForm()
        {
            InitializeComponent();
            LoadTestData();
            UpdateProductGridHeaders();
        }
        private void LoadTestData()
        {
            allProducts = TestDataGenerator.GetSampleProducts();
            dgvProducts.DataSource = allProducts;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
           

        }
        public void RefreshProductGrid()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = allProducts;
            UpdateProductGridHeaders();


        }
        private void btnSeaarch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var filtered = allProducts
                .Where(p => p.Name.ToLower().Contains(query))
                .ToList();

            dgvProducts.DataSource = filtered;
            UpdateProductGridHeaders();

        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            //InvoiceForm invoiceForm = new InvoiceForm(allProducts);
            //invoiceForm.ShowDialog();
            var invoiceForm = new InvoiceForm(allProducts);
            invoiceForm.ShowDialog();
            //invoiceForm.FormClosing += (s, args) => RefreshProductGrid();
            //invoiceForm.ShowDialog();
            RefreshProductGrid();
            UpdateProductGridHeaders();


        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(allProducts);
            inventoryForm.ShowDialog();
        }

        private void LoadProoductsFormFile()
        {
            if (File.Exists("products.json"))
            {
                string json = File.ReadAllText("products.json");
                allProducts = JsonSerializer.Deserialize<List<Product>>(json);

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = allProducts;
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

        private void btnClearTxtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void створитиНакладнуToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void створитиНакладнуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //var invoiceForm = new InvoiceForm(allProducts);
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
            if (dgvProducts.Columns.Count == 0) return;

            dgvProducts.Columns["Name"].HeaderText = "Назва";
            dgvProducts.Columns["Unit"].HeaderText = "Одиниця виміру";
            dgvProducts.Columns["PricePerUnit"].HeaderText = "Ціна за одиницю";
            dgvProducts.Columns["Quantity"].HeaderText = "Кількість";
            dgvProducts.Columns["LastDeliveryDate"].HeaderText = "Дата останнього завезення";

        }
    }
}
