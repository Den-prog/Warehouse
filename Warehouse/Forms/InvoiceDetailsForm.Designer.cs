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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetailsForm));
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
            dgvInvoiceItems.AllowUserToAddRows = false;
            dgvInvoiceItems.AllowUserToDeleteRows = false;
            dgvInvoiceItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInvoiceItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoiceItems.BackgroundColor = SystemColors.Control;
            dgvInvoiceItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceItems.GridColor = SystemColors.ControlLight;
            dgvInvoiceItems.Location = new Point(12, 80);
            dgvInvoiceItems.MultiSelect = false;
            dgvInvoiceItems.Name = "dgvInvoiceItems";
            dgvInvoiceItems.ReadOnly = true;
            dgvInvoiceItems.Size = new Size(805, 430);
            dgvInvoiceItems.TabIndex = 0;
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Font = new Font("Segoe UI", 9.75F);
            lblInvoiceNumber.Location = new Point(12, 14);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(115, 17);
            lblInvoiceNumber.TabIndex = 1;
            lblInvoiceNumber.Text = "Номер накладної:";
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Font = new Font("Segoe UI", 9.75F);
            lblInvoiceDate.Location = new Point(12, 46);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(109, 17);
            lblInvoiceDate.TabIndex = 2;
            lblInvoiceDate.Text = "Дата створення: ";
            // 
            // lblInvoiceType
            // 
            lblInvoiceType.AutoSize = true;
            lblInvoiceType.Font = new Font("Segoe UI", 9.75F);
            lblInvoiceType.Location = new Point(207, 14);
            lblInvoiceType.Name = "lblInvoiceType";
            lblInvoiceType.Size = new Size(32, 17);
            lblInvoiceType.TabIndex = 3;
            lblInvoiceType.Text = "Тип:";
            // 
            // lblInvoiceSuma
            // 
            lblInvoiceSuma.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblInvoiceSuma.AutoSize = true;
            lblInvoiceSuma.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblInvoiceSuma.Location = new Point(638, 523);
            lblInvoiceSuma.Name = "lblInvoiceSuma";
            lblInvoiceSuma.Size = new Size(48, 17);
            lblInvoiceSuma.TabIndex = 4;
            lblInvoiceSuma.Text = "Сума: ";
            // 
            // InvoiceDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 551);
            Controls.Add(lblInvoiceSuma);
            Controls.Add(lblInvoiceType);
            Controls.Add(lblInvoiceDate);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(dgvInvoiceItems);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(845, 590);
            Name = "InvoiceDetailsForm";
            Text = "Перегляд накладної";
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