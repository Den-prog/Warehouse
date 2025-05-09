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
            textBox1 = new TextBox();
            nudQuantity = new NumericUpDown();
            comboBoxInvoiceType = new ComboBox();
            btnAddItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(33, 42);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(616, 150);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 270);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(529, 234);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 2;
            // 
            // comboBoxInvoiceType
            // 
            comboBoxInvoiceType.FormattingEnabled = true;
            comboBoxInvoiceType.Location = new Point(381, 234);
            comboBoxInvoiceType.Name = "comboBoxInvoiceType";
            comboBoxInvoiceType.Size = new Size(121, 23);
            comboBoxInvoiceType.TabIndex = 3;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(529, 269);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "AddItem";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddItem);
            Controls.Add(comboBoxInvoiceType);
            Controls.Add(nudQuantity);
            Controls.Add(textBox1);
            Controls.Add(dgvProducts);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private TextBox textBox1;
        private NumericUpDown nudQuantity;
        private ComboBox comboBoxInvoiceType;
        private Button btnAddItem;
    }
}