namespace Warehouse.Forms
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            txtName = new TextBox();
            nudPrice = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            label4 = new Label();
            nudQuantity = new NumericUpDown();
            cmbUnit = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(288, 25);
            txtName.TabIndex = 0;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(135, 163);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(120, 25);
            nudPrice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 19);
            label1.TabIndex = 4;
            label1.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(114, 19);
            label2.TabIndex = 5;
            label2.Text = "Одиниця виміру";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 6;
            label3.Text = "Ціна за одиницю";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 216);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 30);
            btnSave.TabIndex = 7;
            btnSave.Text = "Додати товар";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 108);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 9;
            label4.Text = "Кількість";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(135, 108);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 25);
            nudQuantity.TabIndex = 10;
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(135, 60);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(120, 25);
            cmbUnit.TabIndex = 11;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 286);
            Controls.Add(cmbUnit);
            Controls.Add(nudQuantity);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudPrice);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(510, 325);
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Новий товар";
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private NumericUpDown nudPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Label label4;
        private NumericUpDown nudQuantity;
        private ComboBox cmbUnit;
    }
}