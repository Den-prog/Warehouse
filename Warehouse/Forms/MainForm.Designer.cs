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
            dgvInvoices = new DataGridView();
            btnCreateInvoice = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            створитиНакладнуToolStripMenuItem1 = new ToolStripMenuItem();
            bnInventory = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInvoices
            // 
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Location = new Point(12, 115);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.Size = new Size(810, 210);
            dgvInvoices.TabIndex = 2;
            dgvInvoices.CellContentClick += dgvProducts_CellContentClick;
            dgvInvoices.CellDoubleClick += dgvInvoices_CellDoubleClick;
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.Location = new Point(12, 38);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.Size = new Size(127, 23);
            btnCreateInvoice.TabIndex = 3;
            btnCreateInvoice.Text = "Створити накладну";
            btnCreateInvoice.UseVisualStyleBackColor = true;
            btnCreateInvoice.Click += btnCreateInvoice_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, створитиНакладнуToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(834, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вихідToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            файлToolStripMenuItem.Click += файлToolStripMenuItem_Click;
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(103, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // створитиНакладнуToolStripMenuItem1
            // 
            створитиНакладнуToolStripMenuItem1.Name = "створитиНакладнуToolStripMenuItem1";
            створитиНакладнуToolStripMenuItem1.Size = new Size(125, 20);
            створитиНакладнуToolStripMenuItem1.Text = "Створити накладну";
            створитиНакладнуToolStripMenuItem1.Click += створитиНакладнуToolStripMenuItem1_Click;
            // 
            // bnInventory
            // 
            bnInventory.Location = new Point(175, 38);
            bnInventory.Name = "bnInventory";
            bnInventory.Size = new Size(173, 23);
            bnInventory.TabIndex = 10;
            bnInventory.Text = "Інвентарна відомість ";
            bnInventory.UseVisualStyleBackColor = true;
            bnInventory.Click += bnInventory_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 724);
            Controls.Add(bnInventory);
            Controls.Add(btnCreateInvoice);
            Controls.Add(dgvInvoices);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvInvoices;
        private Button btnCreateInvoice;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem створитиНакладнуToolStripMenuItem1;
        private Button bnInventory;
    }
}