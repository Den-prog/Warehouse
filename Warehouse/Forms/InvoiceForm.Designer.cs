namespace Warehouse.Forms
{
    partial class InvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            nudQuantity = new NumericUpDown();
            comboBoxInvoiceType = new ComboBox();
            btnAddItem = new Button();
            SaveInvoice = new Button();
            btnDelProduct = new Button();
            menuStrip1 = new MenuStrip();
            видалитиТоварToolStripMenuItem = new ToolStripMenuItem();
            зберегтиНакладнуToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(29, 92);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(616, 150);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(197, 266);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 2;
            // 
            // comboBoxInvoiceType
            // 
            comboBoxInvoiceType.FormattingEnabled = true;
            comboBoxInvoiceType.Location = new Point(49, 266);
            comboBoxInvoiceType.Name = "comboBoxInvoiceType";
            comboBoxInvoiceType.Size = new Size(121, 23);
            comboBoxInvoiceType.TabIndex = 3;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(197, 301);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "AddItem";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // SaveInvoice
            // 
            SaveInvoice.Location = new Point(12, 502);
            SaveInvoice.Name = "SaveInvoice";
            SaveInvoice.Size = new Size(115, 23);
            SaveInvoice.TabIndex = 5;
            SaveInvoice.Text = "SaveInvoice";
            SaveInvoice.UseVisualStyleBackColor = true;
            SaveInvoice.Click += SaveInvoice_Click;
            // 
            // btnDelProduct
            // 
            btnDelProduct.Location = new Point(147, 502);
            btnDelProduct.Name = "btnDelProduct";
            btnDelProduct.Size = new Size(115, 23);
            btnDelProduct.TabIndex = 7;
            btnDelProduct.Text = "Видалити товар";
            btnDelProduct.UseVisualStyleBackColor = true;
            btnDelProduct.Click += btnDelProduct_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { видалитиТоварToolStripMenuItem, зберегтиНакладнуToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // видалитиТоварToolStripMenuItem
            // 
            видалитиТоварToolStripMenuItem.Name = "видалитиТоварToolStripMenuItem";
            видалитиТоварToolStripMenuItem.Size = new Size(105, 20);
            видалитиТоварToolStripMenuItem.Text = "Видалити товар";
            видалитиТоварToolStripMenuItem.Click += видалитиТоварToolStripMenuItem_Click;
            // 
            // зберегтиНакладнуToolStripMenuItem
            // 
            зберегтиНакладнуToolStripMenuItem.Name = "зберегтиНакладнуToolStripMenuItem";
            зберегтиНакладнуToolStripMenuItem.Size = new Size(123, 20);
            зберегтиНакладнуToolStripMenuItem.Text = "Зберегти накладну";
            зберегтиНакладнуToolStripMenuItem.Click += зберегтиНакладнуToolStripMenuItem_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 692);
            Controls.Add(btnDelProduct);
            Controls.Add(SaveInvoice);
            Controls.Add(btnAddItem);
            Controls.Add(comboBoxInvoiceType);
            Controls.Add(nudQuantity);
            Controls.Add(dgvProducts);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private NumericUpDown nudQuantity;
        private ComboBox comboBoxInvoiceType;
        private Button btnAddItem;
        private Button SaveInvoice;
        private Button btnDelProduct;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem видалитиТоварToolStripMenuItem;
        private ToolStripMenuItem зберегтиНакладнуToolStripMenuItem;
    }
}