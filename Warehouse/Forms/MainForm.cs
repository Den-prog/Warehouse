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
        public MainForm()
        {
            InitializeComponent();
            LoadTestData();
        }
        private void LoadTestData()
        {
            allProducts = TestDataGenerator.GetSampleProducts();
            dgvProducts.DataSource = allProducts;

        }

        private void btnSeaarch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var filtered = allProducts
                .Where(p => p.Name.ToLower().Contains(query))
                .ToList();

            dgvProducts.DataSource = filtered;
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm(allProducts);
            invoiceForm.ShowDialog();
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
    }
}
