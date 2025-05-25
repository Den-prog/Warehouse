namespace Warehouse.Forms
{
    partial class InvoiceDetailsForm
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
            dgvInvoiceItems = new DataGridView();
            lblInvoiceNumber = new Label();
            lblInvoiceDate = new Label();
            lblInvoiceType = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceItems).BeginInit();
            SuspendLayout();
            // 
            // dgvInvoiceItems
            // 
            dgvInvoiceItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceItems.Location = new Point(19, 71);
            dgvInvoiceItems.Name = "dgvInvoiceItems";
            dgvInvoiceItems.Size = new Size(652, 150);
            dgvInvoiceItems.TabIndex = 0;
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Location = new Point(15, 13);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(38, 15);
            lblInvoiceNumber.TabIndex = 1;
            lblInvoiceNumber.Text = "label1";
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Location = new Point(87, 15);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(38, 15);
            lblInvoiceDate.TabIndex = 2;
            lblInvoiceDate.Text = "label1";
            // 
            // lblInvoiceType
            // 
            lblInvoiceType.AutoSize = true;
            lblInvoiceType.Location = new Point(157, 13);
            lblInvoiceType.Name = "lblInvoiceType";
            lblInvoiceType.Size = new Size(38, 15);
            lblInvoiceType.TabIndex = 3;
            lblInvoiceType.Text = "label1";
            // 
            // InvoiceDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInvoiceType);
            Controls.Add(lblInvoiceDate);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(dgvInvoiceItems);
            Name = "InvoiceDetailsForm";
            Text = "InvoiceDetailsForm";
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInvoiceItems;
        private Label lblInvoiceNumber;
        private Label lblInvoiceDate;
        private Label lblInvoiceType;
    }
}