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
            lblInvoiceSuma = new Label();
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
            lblInvoiceNumber.Location = new Point(12, 31);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(106, 15);
            lblInvoiceNumber.TabIndex = 1;
            lblInvoiceNumber.Text = "Номер накладної:";
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Location = new Point(159, 31);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(38, 15);
            lblInvoiceDate.TabIndex = 2;
            lblInvoiceDate.Text = "Дата: ";
            // 
            // lblInvoiceType
            // 
            lblInvoiceType.AutoSize = true;
            lblInvoiceType.Location = new Point(275, 31);
            lblInvoiceType.Name = "lblInvoiceType";
            lblInvoiceType.Size = new Size(30, 15);
            lblInvoiceType.TabIndex = 3;
            lblInvoiceType.Text = "Тип:";
            // 
            // lblInvoiceSuma
            // 
            lblInvoiceSuma.AutoSize = true;
            lblInvoiceSuma.Location = new Point(29, 320);
            lblInvoiceSuma.Name = "lblInvoiceSuma";
            lblInvoiceSuma.Size = new Size(42, 15);
            lblInvoiceSuma.TabIndex = 4;
            lblInvoiceSuma.Text = "Сума: ";
            // 
            // InvoiceDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInvoiceSuma);
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
        private Label lblInvoiceSuma;
    }
}