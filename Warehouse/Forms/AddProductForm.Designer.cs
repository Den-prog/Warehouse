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
            txtName.Location = new Point(136, 89);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(136, 201);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(120, 23);
            nudPrice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 92);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 135);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 5;
            label2.Text = "Одиниця виміру";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 203);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 6;
            label3.Text = "Ціна за одиницю";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(116, 264);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "ОК";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 174);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "Кількість";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(136, 172);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 10;
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(136, 132);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(121, 23);
            cmbUnit.TabIndex = 11;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbUnit);
            Controls.Add(nudQuantity);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudPrice);
            Controls.Add(txtName);
            Name = "AddProductForm";
            Text = "AddProductForm";
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