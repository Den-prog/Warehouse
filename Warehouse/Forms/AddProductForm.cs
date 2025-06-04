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
    public partial class AddProductForm : Form
    {
        public Product NewProduct { get; set; }

        public AddProductForm()
        {
            InitializeComponent();
            nudPrice.Minimum = 0;
            nudPrice.Maximum = 100000;

            nudQuantity.Minimum = 0;
            nudQuantity.Maximum = 100000;

            cmbUnit.Items.AddRange(new string[] { "шт", "кг", "л" });

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Усі поля мають бути заповнені.");
                return;
            }

            var unit = cmbUnit.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Оберіть одиницю виміру!");
                return;
            }

            NewProduct = new Product
            {
                Name = txtName.Text,
                Unit = unit,
                PricePerUnit = nudPrice.Value,
                Quantity = (int)nudQuantity.Value,
                LastDeliveryDate = DateTime.Now
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
