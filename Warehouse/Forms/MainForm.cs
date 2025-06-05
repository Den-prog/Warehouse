using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Warehouse.Forms
{
    // Класс MainForm відповідає за управлінням складом.
    //Забезпечує доступ до створення, перегляду, збереження та завантаження накладних і товарів,
    //а також до функцій інвентаризації.
    public partial class MainForm : Form
    {
        private List<Invoice> invoices = new List<Invoice>();

        private AllInvoicesForm allInvoicesForm;

        private List<Product> allProducts = new List<Product>();


        // Конструктор MainForm. Ініціалізує форму, завантажує тестові дані та підписується на події.
        public MainForm()
        {
            InitializeComponent();
            LoadTestData();
            this.FormClosing += MainForm_FormClosing;
            this.Load += MainForm_Load;
        }

        // Метод завантажує тестові дані товарів для початкового наповнення складу.
        private void LoadTestData()
        {
            allProducts = TestDataGenerator.GetSampleProducts();
        }

        // Обробник події закриття форми. Автоматично зберігає дані перед закриттям.
        private void MainForm_FormClosing(object sender, EventArgs e)
        {
            AutoSaveData();
        }
        // Обробник події завантаження форми. Автоматично завантажує дані при старті.
        private void MainForm_Load(object sender, EventArgs e)
        {
            AutoLoadData();
        }
        // Метод серіалізує та зберігає поточні дані складу (товари та накладні) у файл JSON.
        private void AutoSaveData()
        {

            var data = new WarehouseData { Products = allProducts, Invoices = invoices };
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("warehouse_data.json", json);
        }
        // Метод завантажує дані складу (товари та накладні) з файлу JSON.
        private void AutoLoadData()
        {

            if (File.Exists("warehouse_data.json"))
            {
                string json = File.ReadAllText("warehouse_data.json");
                var data = JsonSerializer.Deserialize<WarehouseData>(json);

                if (data != null)
                {
                    allProducts = data.Products ?? new List<Product>();
                    invoices = data.Invoices ?? new List<Invoice>();
                    Invoice.UpdateNextId(invoices);
                }
            }
        }
  

        // Метод відкриває вікно інвентаризації для перегляду поточного списку товарів.
        private void bnInventory_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryForm(allProducts);
            inventoryForm.ShowDialog();
        }

        // Метод відкриває і виводить на передній план вікно перегляду всіх накладних.
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
                allInvoicesForm.BringToFront();
            }
        }


        // Метод відкриває форму для створення нової накладної.
        private void створитиНакладнуToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
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
                }
            }
        }
        // Метод зберігає всі накладні у файл JSON, де користувач обирає директорію для збереження файлу.
        private void зберегтиВсіНакладніToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "накладні.json";
            saveFileDialog.Title = "Зберегти всі накладні";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;

                    string json = JsonSerializer.Serialize(invoices, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);

                    MessageBox.Show("Накладні успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка збереження накладних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Метод завантажує накладні з файлу JSON, обраного користувачем, та оновлює список накладних.
        private void завантажитиНакладніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Завантажити накладні";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filepath = openFileDialog.FileName;
                    string json = File.ReadAllText(filepath);

                    var LoadAllInvoices = JsonSerializer.Deserialize<List<Invoice>>(json);

                    Invoice.UpdateNextId(LoadAllInvoices);
                    invoices = LoadAllInvoices;
                    MessageBox.Show($"Накладні завантажені", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        // Метод відкриває форму інвентаризації для перегляду поточного списку товарів.
        private void інвентарнаВідомістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryForm(allProducts);
            inventoryForm.ShowDialog();
        }
        // Метод зберігає товари та накладні у файл JSON, де користувач обирає директорію для збереження файлу.
        private void зберегтиДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = new WarehouseData { Products = allProducts, Invoices = invoices };
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "склад_накладні.json";
            saveFileDialog.Title = "Зберегти склад і накладні";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;

                    string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);

                    MessageBox.Show("Збережено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка збереження даних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Метод завантажує  дані про товари та накладні з файлу JSON, обраного користувачем.

        private void завантаженняДанихToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Імпорт складу і накладних";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filepath = openFileDialog.FileName;
                    string json = File.ReadAllText(filepath);

                    var LoadWareHouseData = JsonSerializer.Deserialize<WarehouseData>(json);
                    if (LoadWareHouseData != null)
                    {
                        allProducts = LoadWareHouseData.Products ?? new List<Product>();
                        invoices = LoadWareHouseData.Invoices ?? new List<Invoice>();

                        Invoice.UpdateNextId(invoices);
                    }

                    MessageBox.Show($"Дані завантажені!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
