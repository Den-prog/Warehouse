namespace Warehouse.Forms
{
    partial class AllInvoicesForm
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
            dgvAllInvoices = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAllInvoices).BeginInit();
            SuspendLayout();
            // 
            // dgvAllInvoices
            // 
            dgvAllInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllInvoices.Location = new Point(12, 109);
            dgvAllInvoices.Name = "dgvAllInvoices";
            dgvAllInvoices.Size = new Size(739, 204);
            dgvAllInvoices.TabIndex = 0;
            dgvAllInvoices.CellDoubleClick += dgvInvoices_CellDoubleClick;
            // 
            // AllInvoicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAllInvoices);
            Name = "AllInvoicesForm";
            Text = "AllInvoices";
            ((System.ComponentModel.ISupportInitialize)dgvAllInvoices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAllInvoices;
    }
}