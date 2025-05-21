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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Усі поля мають бути заповнені.");
                return;
            }

            NewProduct = new Product
            {
                Name = txtName.Text,
                Unit = txtUnit.Text,
                PricePerUnit = nudPrice.Value,
                Quantity = (int)nudQuantity.Value,
                LastDeliveryDate = DateTime.Now
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
