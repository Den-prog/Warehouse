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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvProducts = new DataGridView();
            nudQuantity = new NumericUpDown();
            comboBoxInvoiceType = new ComboBox();
            btnAddItem = new Button();
            SaveInvoice = new Button();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.Location = new Point(12, 60);
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
            comboBoxInvoiceType.SelectedIndexChanged += comboBoxInvoiceType_SelectedIndexChanged;
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
            SaveInvoice.Location = new Point(29, 412);
            SaveInvoice.Name = "SaveInvoice";
            SaveInvoice.Size = new Size(115, 23);
            SaveInvoice.TabIndex = 5;
            SaveInvoice.Text = "SaveInvoice";
            SaveInvoice.UseVisualStyleBackColor = true;
            SaveInvoice.Click += SaveInvoice_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 692);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private NumericUpDown nudQuantity;
        private ComboBox comboBoxInvoiceType;
        private Button btnAddItem;
        private Button SaveInvoice;
        private MenuStrip menuStrip1;
    }
}