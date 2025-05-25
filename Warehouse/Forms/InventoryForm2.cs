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
    public partial class InventoryForm2 : Form
    {
        private List<Product> products;
        private List<Product> originalProducts;

        private string filePath = "products.json";

        private bool isSaved = true;
        public InventoryForm2()
        {
            InitializeComponent();
            
            products = LoadProducts();
            originalProducts = CloneProductList(products);

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = products;

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

            }
        }


        private void SaveProducts()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(products, options);
            File.WriteAllText(filePath, json);
        }

        private List<Product> LoadProducts()
        {
            if (!File.Exists(filePath))
                return new List<Product>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Product>>(json);
        }

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
                  "Ви не зберегли накладну. Зберегти перед виходом?",
                  "Підтвердження",
                  MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    SaveProducts();
                    isSaved= true;
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
        }



    }
}
