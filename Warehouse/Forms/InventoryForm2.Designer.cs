namespace Warehouse.Forms
{
    partial class InventoryForm2
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
            додатиТоварToolStripMenuItem = new ToolStripMenuItem();
            видалитиТоварToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(12, 71);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(776, 308);
            dgvInventory.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { додатиТоварToolStripMenuItem, видалитиТоварToolStripMenuItem, зберегтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
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
            // InventoryForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}