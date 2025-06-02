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
    public partial class InventoryForm : Form
    {
        private List<Product> products;
        private List<Product> originalProducts;

        private string filePath = "products.json";

        private bool isSaved = true;
        public InventoryForm(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
            //products = LoadProducts();
            originalProducts = CloneProductList(products);

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = products;
            UpdateProductGridHeaders();

            this.FormClosing += InventoryForm2_FormClosing;

        }

        private void додатиТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProduct = new AddProductForm();
            if (addProduct.ShowDialog() == DialogResult.OK)
            {
                products.Add(addProduct.NewProduct);
                isSaved = false;

                dgvInventory.DataSource = null;
                dgvInventory.DataSource = products;
                UpdateProductGridHeaders();

            }
        }


        private void SaveProducts()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(products, options);
            File.WriteAllText(filePath, json);
        }

        //private List<Product> LoadProducts()
        //{
        //    if (!File.Exists(filePath))
        //        return new List<Product>();

        //    string json = File.ReadAllText(filePath);
        //    return JsonSerializer.Deserialize<List<Product>>(json);
        //}

        private List<Product> CloneProductList(List<Product> source)
        {
            return source.Select(p => new Product
            {
                Name = p.Name,
                Quantity = p.Quantity,
                PricePerUnit = p.PricePerUnit,
                Unit = p.Unit,
                LastDeliveryDate = p.LastDeliveryDate,
            }).ToList();
            UpdateProductGridHeaders();
        }
       


        private void видалитиТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть товар для видалення");
                return;
            }

            var selectedProduct = dgvInventory.SelectedRows[0].DataBoundItem as Product;
            if (selectedProduct != null)
            {
                var confirm = MessageBox.Show($"Ви дійсно хочете видалити товар \"{selectedProduct.Name}\" ? ", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    products.Remove(selectedProduct);
                    isSaved = false;

                    dgvInventory.DataSource = null;
                    dgvInventory.DataSource = products;
                    UpdateProductGridHeaders();
                }
            }

        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProducts();
            isSaved = true;
            originalProducts = CloneProductList(products);

            MessageBox.Show("Зберіжино успішно.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InventoryForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                var result = MessageBox.Show(
                  "Ви не зберегли дані. Зберегти перед виходом?",
                  "Підтвердження",
                  MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    SaveProducts();
                    isSaved = true;
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
            products = CloneProductList(originalProducts);
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = products;
            UpdateProductGridHeaders();
        }

        private void зберегтиСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "products.json";
            saveFileDialog.Title = "Зберегти склад";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;

                    string json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);

                    MessageBox.Show("Склад успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка збереження складу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadProoductsFormFile()
        {
            if (File.Exists("products.json"))
            {
                string json = File.ReadAllText("products.json");
                products = JsonSerializer.Deserialize<List<Product>>(json);

                dgvInventory.DataSource = null;
                dgvInventory.DataSource = products;
                UpdateProductGridHeaders();
            }
        }

        private void UpdateProductGridHeaders()
        {
            if (dgvInventory.Columns.Count == 0) return;

            dgvInventory.Columns["Name"].HeaderText = "Назва";
            dgvInventory.Columns["Unit"].HeaderText = "Одиниця виміру";
            dgvInventory.Columns["PricePerUnit"].HeaderText = "Ціна за одиницю";
            dgvInventory.Columns["Quantity"].HeaderText = "Кількість";
            dgvInventory.Columns["LastDeliveryDate"].HeaderText = "Дата останнього завезення";
            dgvInventory.Columns["TotalValue"].HeaderText = "Загальна вартість";

            if(dgvInventory.Columns.Contains("TotalValue") && dgvInventory.Columns.Contains("PricePerUnit"))
            {
                DataGridViewColumn totalValueColumn = dgvInventory.Columns["TotalValue"];
                DataGridViewColumn priceColumn = dgvInventory.Columns["PricePerUnit"];
                totalValueColumn.DefaultCellStyle.Format = "C2";
                priceColumn.DefaultCellStyle.Format = "C2";// Форматування як валюти
                //totalValueColumn.DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("uk-UA");
            }

            /* if(dgvProducts.Columns.Contains("PricePerUnit"))
           {
               DataGridViewColumn priceColumn = dgvProducts.Columns["PricePerUnit"];
       priceColumn.DefaultCellStyle.Format = "C2"; // Форматування як валюти
               //priceColumn.DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("uk-UA");
           }*/
        }
        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Завантажити склад";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filepath = openFileDialog.FileName;
                    string json = File.ReadAllText(filepath);

                    var LoadProducts = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
                    products.Clear();
                    products.AddRange(LoadProducts);
                    isSaved = true;
                    originalProducts = CloneProductList(products);

                    dgvInventory.DataSource = null;
                    dgvInventory.DataSource = products;
                    UpdateProductGridHeaders();

                    MessageBox.Show($"Cклад завантажений", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (JsonException jsonEx)
                {
                    MessageBox.Show($"Помилка десеріалізації JSON: {jsonEx.Message}\n Переконайтеся, що файл має коректний формат JSON та відповідає структурі даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при завантажені: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSeaarch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var filtered = products
                .Where(p => p.Name.ToLower().Contains(query))
                .ToList();

            dgvInventory.DataSource = filtered;
            UpdateProductGridHeaders();
        }

        private void btnClearTxtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
