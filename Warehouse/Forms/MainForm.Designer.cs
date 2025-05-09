namespace Warehouse.Forms
{
    partial class MainForm
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
            txtSearch = new TextBox();
            btnSeaarch = new Button();
            dgvProducts = new DataGridView();
            btnCreateInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(55, 87);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnSeaarch
            // 
            btnSeaarch.Location = new Point(55, 146);
            btnSeaarch.Name = "btnSeaarch";
            btnSeaarch.Size = new Size(75, 23);
            btnSeaarch.TabIndex = 1;
            btnSeaarch.Text = "Знайти";
            btnSeaarch.UseVisualStyleBackColor = true;
            btnSeaarch.Click += btnSeaarch_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(55, 189);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(701, 150);
            dgvProducts.TabIndex = 2;
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.Location = new Point(28, 27);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.Size = new Size(127, 23);
            btnCreateInvoice.TabIndex = 3;
            btnCreateInvoice.Text = "Створити накладну";
            btnCreateInvoice.UseVisualStyleBackColor = true;
            btnCreateInvoice.Click += btnCreateInvoice_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateInvoice);
            Controls.Add(dgvProducts);
            Controls.Add(btnSeaarch);
            Controls.Add(txtSearch);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSeaarch;
        private DataGridView dgvProducts;
        private Button btnCreateInvoice;
    }
}