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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            dgvProducts = new DataGridView();
            nudQuantity = new NumericUpDown();
            comboBoxInvoiceType = new ComboBox();
            btnAddItem = new Button();
            SaveInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.Control;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.GridColor = SystemColors.ControlLight;
            dgvProducts.Location = new Point(12, 62);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(725, 590);
            dgvProducts.TabIndex = 0;
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudQuantity.Location = new Point(756, 74);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(126, 25);
            nudQuantity.TabIndex = 2;
            // 
            // comboBoxInvoiceType
            // 
            comboBoxInvoiceType.FormattingEnabled = true;
            comboBoxInvoiceType.Location = new Point(12, 22);
            comboBoxInvoiceType.Name = "comboBoxInvoiceType";
            comboBoxInvoiceType.Size = new Size(187, 25);
            comboBoxInvoiceType.TabIndex = 3;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddItem.Location = new Point(756, 118);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(126, 27);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "Додати позицію";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // SaveInvoice
            // 
            SaveInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaveInvoice.Location = new Point(773, 170);
            SaveInvoice.Name = "SaveInvoice";
            SaveInvoice.Size = new Size(91, 48);
            SaveInvoice.TabIndex = 5;
            SaveInvoice.Text = "Зберегти накладну";
            SaveInvoice.UseVisualStyleBackColor = true;
            SaveInvoice.Click += SaveInvoice_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 706);
            Controls.Add(SaveInvoice);
            Controls.Add(btnAddItem);
            Controls.Add(comboBoxInvoiceType);
            Controls.Add(nudQuantity);
            Controls.Add(dgvProducts);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(910, 745);
            Name = "InvoiceForm";
            Text = "Накладна";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private NumericUpDown nudQuantity;
        private ComboBox comboBoxInvoiceType;
        private Button btnAddItem;
        private Button SaveInvoice;
    }
}