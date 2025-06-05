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
    // Клас AllInvoicesForm відповідає за перегляд, фільтрацію, детальний перегляд та видалення накладних.
    public partial class AllInvoicesForm : Form
    {
        private List<Invoice> allInvoices;

        // Метод ініціалізує форму, завантажує список накладних та налаштовує елементи керування.
        public AllInvoicesForm(List<Invoice> invoices)
        {
            InitializeComponent();
            allInvoices = invoices;
           
            Invoice.UpdateNextId(allInvoices);
            LoadInvoices(allInvoices);

            cmbType.Items.Add("Всі");
            cmbType.Items.Add("Прибуткова накладна");
            cmbType.Items.Add("Витратна накладна");
            cmbType.SelectedIndex = 0;
        }
        // Метод завантажує та відображає список накладних у таблиці.
        private void LoadInvoices(List<Invoice> invoicesToShow)
        {
            dgvAllInvoices.DataSource = null;
            dgvAllInvoices.DataSource = invoicesToShow.Select(inv => new
            {
                inv.Id,
                Тип = inv.Type == InvoiceType.Income ? "Прибуткова накладна" : "Витратна накладна",
                Date = inv.Date.ToShortDateString(),
                КількістьТоварів = inv.Items?.Count ?? 0
            }).ToList();

            dgvAllInvoices.Columns[0].HeaderText = "ID";
            dgvAllInvoices.Columns[2].HeaderText = "Дата";
            dgvAllInvoices.Columns[3].HeaderText = "Кількість товарів";
        }

        // Метод відкриває деталі накладної при подвійному кліку по рядку таблиці.
        private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int id = (int)dgvAllInvoices.Rows[e.RowIndex].Cells[0].Value;
                var selected = allInvoices.FirstOrDefault(i => i.Id == id);
                if (selected != null)
                {
                    InvoiceDetailsForm detailsForm = new InvoiceDetailsForm(selected);
                    detailsForm.ShowDialog();
                }
            }
        }

        // Метод оновлює список накладних у формі.
        public void UpdateInvoices(List<Invoice> updatedInvoices)
        {
            this.allInvoices = updatedInvoices;
            LoadInvoices(allInvoices);

        }

        // Метод фільтрує накладні за типом, датою та кількістю товарів.

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filtered = allInvoices.AsEnumerable();

            if (cmbType.SelectedIndex > 0)
            {
                InvoiceType selectedType = cmbType.SelectedIndex == 1 ? InvoiceType.Income : InvoiceType.Outcome;
                filtered = filtered.Where(inv => inv.Type == selectedType);

            }
            if (dateTimePicker1.Checked)
            {

                var selectedDate = dateTimePicker1.Value.Date;
                filtered = filtered.Where(inv => inv.Date.Date == selectedDate);
            }
            if (nudCount.Value > 0)
            {
                int count = (int)nudCount.Value;
                filtered = filtered.Where(inv => inv.Items.Count == count);
            }
            LoadInvoices(filtered.ToList());
        }
        // Метод видаляє вибрану накладну зі списку.
        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (dgvAllInvoices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть накладну для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            int id = (int)dgvAllInvoices.SelectedRows[0].Cells[0].Value;
            var invoiceToDelete = allInvoices.FirstOrDefault(i => i.Id == id);

            if (invoiceToDelete == null)
            {
                MessageBox.Show("Не вдалося знайти накладну для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"Ви дійсно хочете видалити накладну №{invoiceToDelete.Id}?",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                allInvoices.Remove(invoiceToDelete);
                LoadInvoices(allInvoices);
            }

        }
    }
}
