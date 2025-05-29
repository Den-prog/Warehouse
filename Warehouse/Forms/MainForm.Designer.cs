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
            файлToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            документиToolStripMenuItem = new ToolStripMenuItem();
            створитиНакладнуToolStripMenuItem = new ToolStripMenuItem();
            всіНакладніToolStripMenuItem = new ToolStripMenuItem();
            bnInventory = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, документиToolStripMenuItem });
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
            // документиToolStripMenuItem
            // 
            документиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { створитиНакладнуToolStripMenuItem, всіНакладніToolStripMenuItem });
            документиToolStripMenuItem.Name = "документиToolStripMenuItem";
            документиToolStripMenuItem.Size = new Size(80, 20);
            документиToolStripMenuItem.Text = "Документи";
            документиToolStripMenuItem.Click += документиToolStripMenuItem_Click;
            // 
            // створитиНакладнуToolStripMenuItem
            // 
            створитиНакладнуToolStripMenuItem.Name = "створитиНакладнуToolStripMenuItem";
            створитиНакладнуToolStripMenuItem.Size = new Size(180, 22);
            створитиНакладнуToolStripMenuItem.Text = "Створити накладну";
            створитиНакладнуToolStripMenuItem.Click += створитиНакладнуToolStripMenuItem_Click_2;
            // 
            // всіНакладніToolStripMenuItem
            // 
            всіНакладніToolStripMenuItem.Name = "всіНакладніToolStripMenuItem";
            всіНакладніToolStripMenuItem.Size = new Size(180, 22);
            всіНакладніToolStripMenuItem.Text = "Всі накладні";
            всіНакладніToolStripMenuItem.Click += всіНакладніToolStripMenuItem_Click;
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private Button bnInventory;
        private ToolStripMenuItem документиToolStripMenuItem;
        private ToolStripMenuItem всіНакладніToolStripMenuItem;
        private ToolStripMenuItem створитиНакладнуToolStripMenuItem;
    }
}