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
    public partial class InventoryForm : Form
    {
        private List<Product> products;
        public InventoryForm(List<Product> products)
        {
            InitializeComponent();
            this.products = products;

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = products;
        }


       
    }
}
