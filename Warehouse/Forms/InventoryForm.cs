using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Models;

using System.IO;
namespace Warehouse.Forms
{
    public partial class InventoryForm : Form
    {
        private List<Product> products;
        private List<Product> originalProducts;
        private bool changesMade = false;

        private const string ProductsFilePath = "products.json";
        public InventoryForm(List<Product> products)
        {
            InitializeComponent();
            this.products = products;

            originalProducts = products.Select(p => new Product
            {
                Name = p.Name,
                Unit = p.Unit,
                Quantity = p.Quantity,
                PricePerUnit = p.PricePerUnit,
                LastDeliveryDate = p.LastDeliveryDate
            }).ToList();

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = products;

            this.FormClosing += InventoryForm_FormClosing;
        }
        private void RefreshInventoryDisplay()
        {
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = products;
            changesMade = true; // Внесені зміни
        }
        private void InventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changesMade && this.DialogResult != DialogResult.OK && this.DialogResult != DialogResult.Abort)
            {
                var result = MessageBox.Show(
                    "Ви не зберегли зміни. Зберегти перед виходом?",
                    "Збереження інвентарних змін",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    SaveProductsToFile();
                    this.DialogResult = DialogResult.OK;
                }
                else if (result == DialogResult.No)
                {
                    RollbackChanges();
                    this.DialogResult = DialogResult.Cancel;
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }


        private void RollbackChanges()
        {
            products.Clear();
            foreach (var originalProduct in originalProducts)
            {
                products.Add(originalProduct);
            }
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = products;
            changesMade = false;
        }
        private void SaveProductsToFile()
        {
            try
            {
                // Серіалізуємо список продуктів у JSON-рядок
                string jsonString = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });

                // Записуємо JSON-рядок у файл
                File.WriteAllText(ProductsFilePath, jsonString);

                MessageBox.Show("Зміни успішно збережено у файл " + ProductsFilePath);
                changesMade = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні у JSON: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Новий метод для завантаження списку продуктів з JSON-файлу
        private void LoadProductsFromFile()
        {
            if (File.Exists(ProductsFilePath))
            {
                try
                {
                    // Читаємо весь JSON-рядок з файлу
                    string jsonString = File.ReadAllText(ProductsFilePath);

                    // Десеріалізуємо JSON-рядок у список продуктів
                    List<Product> loadedProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);

                    if (loadedProducts != null)
                    {
                        // Очищаємо поточний список і додаємо завантажені продукти
                        products.Clear();
                        foreach (var product in loadedProducts)
                        {
                            products.Add(product);
                        }
                        // Оновлюємо DataGridView
                        dgvInventory.DataSource = null;
                        dgvInventory.DataSource = products;
                        // Скидаємо прапорець змін, оскільки ми щойно завантажили збережені дані
                        changesMade = false;
                        // Також оновлюємо знімок, щоб він відповідав завантаженим даним
                        originalProducts = products.Select(p => new Product
                        {
                            Name = p.Name,
                            Unit = p.Unit,
                            Quantity = p.Quantity,
                            PricePerUnit = p.PricePerUnit,
                            LastDeliveryDate = p.LastDeliveryDate
                        }).ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при завантаженні з JSON: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void додатиТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProduct = new AddProductForm();
            if (addProduct.ShowDialog() == DialogResult.OK)
            {
                products.Add(addProduct.NewProduct);

                dgvInventory.DataSource = null;
                dgvInventory.DataSource = products;

            }
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
                    dgvInventory.DataSource = null;
                    dgvInventory.DataSource = products;
                }
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveProductsToFile();

        }

        private void загрузитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProductsFromFile();
        }
    }
}
