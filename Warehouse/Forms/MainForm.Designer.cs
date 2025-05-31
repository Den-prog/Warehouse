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
            menuStrip1 = new MenuStrip();
            документиToolStripMenuItem = new ToolStripMenuItem();
            створитиНакладнуToolStripMenuItem = new ToolStripMenuItem();
            всіНакладніToolStripMenuItem = new ToolStripMenuItem();
            зберегтиВсіНакладніToolStripMenuItem1 = new ToolStripMenuItem();
            завантажитиНакладніToolStripMenuItem = new ToolStripMenuItem();
            bnInventory = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { документиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(834, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // документиToolStripMenuItem
            // 
            документиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { створитиНакладнуToolStripMenuItem, всіНакладніToolStripMenuItem, зберегтиВсіНакладніToolStripMenuItem1, завантажитиНакладніToolStripMenuItem });
            документиToolStripMenuItem.Name = "документиToolStripMenuItem";
            документиToolStripMenuItem.Size = new Size(80, 20);
            документиToolStripMenuItem.Text = "Документи";
            документиToolStripMenuItem.Click += документиToolStripMenuItem_Click;
            // 
            // створитиНакладнуToolStripMenuItem
            // 
            створитиНакладнуToolStripMenuItem.Name = "створитиНакладнуToolStripMenuItem";
            створитиНакладнуToolStripMenuItem.Size = new Size(196, 22);
            створитиНакладнуToolStripMenuItem.Text = "Створити накладну";
            створитиНакладнуToolStripMenuItem.Click += створитиНакладнуToolStripMenuItem_Click_2;
            // 
            // всіНакладніToolStripMenuItem
            // 
            всіНакладніToolStripMenuItem.Name = "всіНакладніToolStripMenuItem";
            всіНакладніToolStripMenuItem.Size = new Size(196, 22);
            всіНакладніToolStripMenuItem.Text = "Всі накладні";
            всіНакладніToolStripMenuItem.Click += всіНакладніToolStripMenuItem_Click;
            // 
            // зберегтиВсіНакладніToolStripMenuItem1
            // 
            зберегтиВсіНакладніToolStripMenuItem1.Name = "зберегтиВсіНакладніToolStripMenuItem1";
            зберегтиВсіНакладніToolStripMenuItem1.Size = new Size(196, 22);
            зберегтиВсіНакладніToolStripMenuItem1.Text = "Зберегти всі накладні";
            зберегтиВсіНакладніToolStripMenuItem1.Click += зберегтиВсіНакладніToolStripMenuItem1_Click;
            // 
            // завантажитиНакладніToolStripMenuItem
            // 
            завантажитиНакладніToolStripMenuItem.Name = "завантажитиНакладніToolStripMenuItem";
            завантажитиНакладніToolStripMenuItem.Size = new Size(196, 22);
            завантажитиНакладніToolStripMenuItem.Text = "Завантажити накладні";
            завантажитиНакладніToolStripMenuItem.Click += завантажитиНакладніToolStripMenuItem_Click;
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private Button bnInventory;
        private ToolStripMenuItem документиToolStripMenuItem;
        private ToolStripMenuItem всіНакладніToolStripMenuItem;
        private ToolStripMenuItem створитиНакладнуToolStripMenuItem;
        private ToolStripMenuItem зберегтиВсіНакладніToolStripMenuItem1;
        private ToolStripMenuItem завантажитиНакладніToolStripMenuItem;
    }
}