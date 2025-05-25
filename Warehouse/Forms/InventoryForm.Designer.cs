namespace Warehouse.Forms
{
    partial class InventoryForm
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
            dgvInventory = new DataGridView();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            зберегтиСкладToolStripMenuItem = new ToolStripMenuItem();
            завантажитиToolStripMenuItem = new ToolStripMenuItem();
            додатиТоварToolStripMenuItem = new ToolStripMenuItem();
            видалитиТоварToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSeaarch = new Button();
            btnClearTxtSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(12, 109);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(776, 308);
            dgvInventory.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, додатиТоварToolStripMenuItem, видалитиТоварToolStripMenuItem, зберегтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиСкладToolStripMenuItem, завантажитиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // зберегтиСкладToolStripMenuItem
            // 
            зберегтиСкладToolStripMenuItem.Name = "зберегтиСкладToolStripMenuItem";
            зберегтиСкладToolStripMenuItem.Size = new Size(179, 22);
            зберегтиСкладToolStripMenuItem.Text = "Зберегти склад";
            зберегтиСкладToolStripMenuItem.Click += зберегтиСкладToolStripMenuItem_Click;
            // 
            // завантажитиToolStripMenuItem
            // 
            завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            завантажитиToolStripMenuItem.Size = new Size(179, 22);
            завантажитиToolStripMenuItem.Text = "Завантажити склад";
            завантажитиToolStripMenuItem.Click += завантажитиToolStripMenuItem_Click;
            // 
            // додатиТоварToolStripMenuItem
            // 
            додатиТоварToolStripMenuItem.Name = "додатиТоварToolStripMenuItem";
            додатиТоварToolStripMenuItem.Size = new Size(92, 20);
            додатиТоварToolStripMenuItem.Text = "Додати товар";
            додатиТоварToolStripMenuItem.Click += додатиТоварToolStripMenuItem_Click;
            // 
            // видалитиТоварToolStripMenuItem
            // 
            видалитиТоварToolStripMenuItem.Name = "видалитиТоварToolStripMenuItem";
            видалитиТоварToolStripMenuItem.Size = new Size(105, 20);
            видалитиТоварToolStripMenuItem.Text = "Видалити товар";
            видалитиТоварToolStripMenuItem.Click += видалитиТоварToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(69, 20);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(12, 52);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(148, 19);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Введіть назву товару: ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(166, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 9;
            // 
            // btnSeaarch
            // 
            btnSeaarch.Location = new Point(283, 52);
            btnSeaarch.Name = "btnSeaarch";
            btnSeaarch.Size = new Size(75, 23);
            btnSeaarch.TabIndex = 10;
            btnSeaarch.Text = "Знайти";
            btnSeaarch.UseVisualStyleBackColor = true;
            btnSeaarch.Click += btnSeaarch_Click;
            // 
            // btnClearTxtSearch
            // 
            btnClearTxtSearch.Location = new Point(364, 52);
            btnClearTxtSearch.Name = "btnClearTxtSearch";
            btnClearTxtSearch.Size = new Size(75, 23);
            btnClearTxtSearch.TabIndex = 11;
            btnClearTxtSearch.Text = "Очистити";
            btnClearTxtSearch.UseVisualStyleBackColor = true;
            btnClearTxtSearch.Click += btnClearTxtSearch_Click;
            // 
            // InventoryForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearTxtSearch);
            Controls.Add(btnSeaarch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvInventory);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "InventoryForm2";
            Text = "InventoryForm2";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInventory;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem додатиТоварToolStripMenuItem;
        private ToolStripMenuItem видалитиТоварToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem зберегтиСкладToolStripMenuItem;
        private ToolStripMenuItem завантажитиToolStripMenuItem;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSeaarch;
        private Button btnClearTxtSearch;
    }
}