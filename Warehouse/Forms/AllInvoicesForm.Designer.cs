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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllInvoicesForm));
            dgvAllInvoices = new DataGridView();
            cmbType = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            nudCount = new NumericUpDown();
            btnFilter = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            btnDeleteInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAllInvoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCount).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAllInvoices
            // 
            dgvAllInvoices.AllowUserToAddRows = false;
            dgvAllInvoices.AllowUserToDeleteRows = false;
            dgvAllInvoices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAllInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllInvoices.BackgroundColor = SystemColors.Control;
            dgvAllInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllInvoices.GridColor = SystemColors.ControlLight;
            dgvAllInvoices.Location = new Point(12, 260);
            dgvAllInvoices.MultiSelect = false;
            dgvAllInvoices.Name = "dgvAllInvoices";
            dgvAllInvoices.ReadOnly = true;
            dgvAllInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllInvoices.Size = new Size(764, 436);
            dgvAllInvoices.TabIndex = 0;
            dgvAllInvoices.CellDoubleClick += dgvInvoices_CellDoubleClick;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(126, 14);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(177, 25);
            cmbType.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(126, 66);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(177, 25);
            dateTimePicker1.TabIndex = 2;
            // 
            // nudCount
            // 
            nudCount.Location = new Point(126, 120);
            nudCount.Name = "nudCount";
            nudCount.Size = new Size(177, 25);
            nudCount.TabIndex = 3;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(10, 171);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(152, 29);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Застовувати фільтр";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbType);
            panel1.Controls.Add(btnFilter);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(nudCount);
            panel1.Location = new Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 218);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 73);
            label3.Name = "label3";
            label3.Size = new Size(108, 19);
            label3.TabIndex = 7;
            label3.Text = "Дата створення";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 23);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 6;
            label2.Text = "Тип накладної";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 120);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 5;
            label1.Text = "Кількість товару";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(22, 14);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Фільтр ";
            // 
            // btnDeleteInvoice
            // 
            btnDeleteInvoice.Location = new Point(630, 208);
            btnDeleteInvoice.Name = "btnDeleteInvoice";
            btnDeleteInvoice.Size = new Size(147, 32);
            btnDeleteInvoice.TabIndex = 8;
            btnDeleteInvoice.Text = "Видалити накладну";
            btnDeleteInvoice.UseVisualStyleBackColor = true;
            btnDeleteInvoice.Click += btnDeleteInvoice_Click;
            // 
            // AllInvoicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 711);
            Controls.Add(btnDeleteInvoice);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(dgvAllInvoices);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(805, 750);
            Name = "AllInvoicesForm";
            Text = "Всі накладні";
            ((System.ComponentModel.ISupportInitialize)dgvAllInvoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllInvoices;
        private ComboBox cmbType;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown nudCount;
        private Button btnFilter;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnDeleteInvoice;
    }
}