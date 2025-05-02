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
    }
}
