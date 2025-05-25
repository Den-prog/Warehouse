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
            Inventory = new Button();
            btnSaveToFile = new Button();
            btnLoadFromFile = new Button();
            lblSearch = new Label();
            btnClearTxtSearch = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            зберегтиСкладToolStripMenuItem = new ToolStripMenuItem();
            завантажитиСкладToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            створитиНакладнуToolStripMenuItem1 = new ToolStripMenuItem();
            bnInventory = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(166, 74);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnSeaarch
            // 
            btnSeaarch.Location = new Point(272, 75);
            btnSeaarch.Name = "btnSeaarch";
            btnSeaarch.Size = new Size(75, 23);
            btnSeaarch.TabIndex = 1;
            btnSeaarch.Text = "Знайти";
            btnSeaarch.UseVisualStyleBackColor = true;
            btnSeaarch.Click += btnSeaarch_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 113);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(776, 210);
            dgvProducts.TabIndex = 2;
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
            // Inventory
            // 
            Inventory.Location = new Point(166, 38);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(173, 23);
            Inventory.TabIndex = 4;
            Inventory.Text = "Інвентарна відомість";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(610, 349);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(80, 23);
            btnSaveToFile.TabIndex = 5;
            btnSaveToFile.Text = "Зберегти ";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // btnLoadFromFile
            // 
            btnLoadFromFile.Location = new Point(696, 349);
            btnLoadFromFile.Name = "btnLoadFromFile";
            btnLoadFromFile.Size = new Size(92, 23);
            btnLoadFromFile.TabIndex = 6;
            btnLoadFromFile.Text = "Завантажити ";
            btnLoadFromFile.UseVisualStyleBackColor = true;
            btnLoadFromFile.Click += btnLoadFormFile_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(12, 75);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(148, 19);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Введіть назву товару: ";
            // 
            // btnClearTxtSearch
            // 
            btnClearTxtSearch.Location = new Point(357, 75);
            btnClearTxtSearch.Name = "btnClearTxtSearch";
            btnClearTxtSearch.Size = new Size(75, 23);
            btnClearTxtSearch.TabIndex = 8;
            btnClearTxtSearch.Text = "Очистити";
            btnClearTxtSearch.UseVisualStyleBackColor = true;
            btnClearTxtSearch.Click += btnClearTxtSearch_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, створитиНакладнуToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(820, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиСкладToolStripMenuItem, завантажитиСкладToolStripMenuItem, вихідToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            файлToolStripMenuItem.Click += файлToolStripMenuItem_Click;
            // 
            // зберегтиСкладToolStripMenuItem
            // 
            зберегтиСкладToolStripMenuItem.Name = "зберегтиСкладToolStripMenuItem";
            зберегтиСкладToolStripMenuItem.Size = new Size(179, 22);
            зберегтиСкладToolStripMenuItem.Text = "Зберегти склад";
            зберегтиСкладToolStripMenuItem.Click += зберегтиСкладToolStripMenuItem_Click;
            // 
            // завантажитиСкладToolStripMenuItem
            // 
            завантажитиСкладToolStripMenuItem.Name = "завантажитиСкладToolStripMenuItem";
            завантажитиСкладToolStripMenuItem.Size = new Size(179, 22);
            завантажитиСкладToolStripMenuItem.Text = "Завантажити склад";
            завантажитиСкладToolStripMenuItem.Click += завантажитиСкладToolStripMenuItem_Click;
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(179, 22);
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
            bnInventory.Location = new Point(357, 38);
            bnInventory.Name = "bnInventory";
            bnInventory.Size = new Size(173, 23);
            bnInventory.TabIndex = 10;
            bnInventory.Text = "Інвентарна відомість 2";
            bnInventory.UseVisualStyleBackColor = true;
            bnInventory.Click += bnInventory_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 518);
            Controls.Add(bnInventory);
            Controls.Add(btnClearTxtSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnLoadFromFile);
            Controls.Add(btnSaveToFile);
            Controls.Add(Inventory);
            Controls.Add(btnCreateInvoice);
            Controls.Add(dgvProducts);
            Controls.Add(btnSeaarch);
            Controls.Add(txtSearch);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSeaarch;
        private DataGridView dgvProducts;
        private Button btnCreateInvoice;
        private Button Inventory;
        private Button btnSaveToFile;
        private Button btnLoadFromFile;
        private Label lblSearch;
        private Button btnClearTxtSearch;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem зберегтиСкладToolStripMenuItem;
        private ToolStripMenuItem завантажитиСкладToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem створитиНакладнуToolStripMenuItem1;
        private Button bnInventory;
    }
}