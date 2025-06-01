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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            dgvInventory = new DataGridView();
            menuStrip1 = new MenuStrip();
            складToolStripMenuItem = new ToolStripMenuItem();
            зберегтиСкладНаДискToolStripMenuItem = new ToolStripMenuItem();
            завантажитиToolStripMenuItem = new ToolStripMenuItem();
            додатиТоварToolStripMenuItem = new ToolStripMenuItem();
            видалитиТоварToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSeaarch = new Button();
            btnClearTxtSearch = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(12, 165);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(875, 614);
            dgvInventory.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { складToolStripMenuItem, додатиТоварToolStripMenuItem, видалитиТоварToolStripMenuItem, зберегтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(899, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // складToolStripMenuItem
            // 
            складToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиСкладНаДискToolStripMenuItem, завантажитиToolStripMenuItem });
            складToolStripMenuItem.Name = "складToolStripMenuItem";
            складToolStripMenuItem.Size = new Size(52, 20);
            складToolStripMenuItem.Text = "Склад";
            складToolStripMenuItem.Click += складToolStripMenuItem_Click;
            // 
            // зберегтиСкладНаДискToolStripMenuItem
            // 
            зберегтиСкладНаДискToolStripMenuItem.Name = "зберегтиСкладНаДискToolStripMenuItem";
            зберегтиСкладНаДискToolStripMenuItem.Size = new Size(207, 22);
            зберегтиСкладНаДискToolStripMenuItem.Text = "Зберегти склад(на диск)";
            зберегтиСкладНаДискToolStripMenuItem.Click += зберегтиСкладToolStripMenuItem_Click;
            // 
            // завантажитиToolStripMenuItem
            // 
            завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            завантажитиToolStripMenuItem.Size = new Size(207, 22);
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
            lblSearch.Location = new Point(12, 27);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(141, 19);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Введіть назву товару";
            lblSearch.Click += lblSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(159, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(228, 25);
            txtSearch.TabIndex = 9;
            // 
            // btnSeaarch
            // 
            btnSeaarch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSeaarch.Location = new Point(185, 58);
            btnSeaarch.Name = "btnSeaarch";
            btnSeaarch.Size = new Size(75, 26);
            btnSeaarch.TabIndex = 10;
            btnSeaarch.Text = "Знайти";
            btnSeaarch.UseVisualStyleBackColor = true;
            btnSeaarch.Click += btnSeaarch_Click;
            // 
            // btnClearTxtSearch
            // 
            btnClearTxtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClearTxtSearch.Location = new Point(285, 59);
            btnClearTxtSearch.Name = "btnClearTxtSearch";
            btnClearTxtSearch.Size = new Size(83, 26);
            btnClearTxtSearch.TabIndex = 11;
            btnClearTxtSearch.Text = "Очистити";
            btnClearTxtSearch.UseVisualStyleBackColor = true;
            btnClearTxtSearch.Click += btnClearTxtSearch_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnClearTxtSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(btnSeaarch);
            panel1.Location = new Point(12, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 106);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 14;
            label1.Text = "Пошук товару";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 791);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dgvInventory);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(915, 830);
            Name = "InventoryForm";
            Text = "Інвентарна відомість";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInventory;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem додатиТоварToolStripMenuItem;
        private ToolStripMenuItem видалитиТоварToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem складToolStripMenuItem;
        private ToolStripMenuItem зберегтиСкладНаДискToolStripMenuItem;
        private ToolStripMenuItem завантажитиToolStripMenuItem;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSeaarch;
        private Button btnClearTxtSearch;
        private Panel panel1;
        private Label label1;
    }
}