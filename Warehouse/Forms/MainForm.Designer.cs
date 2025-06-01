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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            зберегтиДаніToolStripMenuItem = new ToolStripMenuItem();
            імпортToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            документиToolStripMenuItem = new ToolStripMenuItem();
            створитиНакладнуToolStripMenuItem = new ToolStripMenuItem();
            всіНакладніToolStripMenuItem = new ToolStripMenuItem();
            зберегтиВсіНакладніToolStripMenuItem1 = new ToolStripMenuItem();
            завантажитиНакладніToolStripMenuItem = new ToolStripMenuItem();
            інвентарнаВідомістьToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, документиToolStripMenuItem, інвентарнаВідомістьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиДаніToolStripMenuItem, імпортToolStripMenuItem, вихідToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // зберегтиДаніToolStripMenuItem
            // 
            зберегтиДаніToolStripMenuItem.Name = "зберегтиДаніToolStripMenuItem";
            зберегтиДаніToolStripMenuItem.Size = new Size(167, 22);
            зберегтиДаніToolStripMenuItem.Tag = "";
            зберегтиДаніToolStripMenuItem.Text = "Зберегти дані";
            зберегтиДаніToolStripMenuItem.Click += зберегтиДаніToolStripMenuItem_Click;
            // 
            // імпортToolStripMenuItem
            // 
            імпортToolStripMenuItem.Name = "імпортToolStripMenuItem";
            імпортToolStripMenuItem.Size = new Size(167, 22);
            імпортToolStripMenuItem.Text = "Імпортувати дані";
            імпортToolStripMenuItem.Click += імпортToolStripMenuItem_Click;
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(167, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click_1;
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
            // інвентарнаВідомістьToolStripMenuItem
            // 
            інвентарнаВідомістьToolStripMenuItem.Name = "інвентарнаВідомістьToolStripMenuItem";
            інвентарнаВідомістьToolStripMenuItem.Size = new Size(133, 20);
            інвентарнаВідомістьToolStripMenuItem.Text = "Інвентарна відомість";
            інвентарнаВідомістьToolStripMenuItem.Click += інвентарнаВідомістьToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 575);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(300, 104);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головна";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem документиToolStripMenuItem;
        private ToolStripMenuItem всіНакладніToolStripMenuItem;
        private ToolStripMenuItem створитиНакладнуToolStripMenuItem;
        private ToolStripMenuItem зберегтиВсіНакладніToolStripMenuItem1;
        private ToolStripMenuItem завантажитиНакладніToolStripMenuItem;
        private ToolStripMenuItem інвентарнаВідомістьToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem імпортToolStripMenuItem;
        private ToolStripMenuItem зберегтиДаніToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
    }
}