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
    public partial class AllInvoicesForm : Form
    {
        private List<Invoice> allInvoices;
        public AllInvoicesForm(List<Invoice> invoices)
        {
            InitializeComponent();
            allInvoices = invoices;
            LoadInvoices(allInvoices?.ToList() ?? new List<Invoice>());
        }
        private void LoadInvoices(List<Invoice> invoicesToShow)
        {
            dgvAllInvoices.AutoGenerateColumns = true;
            dgvAllInvoices.DataSource = null;
            dgvAllInvoices.DataSource = invoicesToShow.Select(inv => new
            {
                inv.Id,
                inv.Type,
                Date = inv.Date.ToShortDateString(),
                КількістьТоварів = inv.Items?.Count ?? 0
            }).ToList();

            dgvAllInvoices.Columns[0].HeaderText = "ID";
            dgvAllInvoices.Columns[1].HeaderText = "Тип";
            dgvAllInvoices.Columns[2].HeaderText = "Дата";
            dgvAllInvoices.Columns[3].HeaderText = "Кількість товарів";


        }
       
       
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

        public void UpdateInvoices(List<Invoice> updatedInvoices)
        {
            this.allInvoices = updatedInvoices;
            LoadInvoices(allInvoices);

        }

    }
}
