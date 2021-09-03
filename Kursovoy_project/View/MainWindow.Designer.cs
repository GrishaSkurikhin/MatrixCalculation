namespace Kursovoy_project.View
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMatrixButton = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.MultButton = new System.Windows.Forms.Button();
            this.TransButton = new System.Windows.Forms.Button();
            this.MultNumButton = new System.Windows.Forms.Button();
            this.PowButton = new System.Windows.Forms.Button();
            this.DetButton = new System.Windows.Forms.Button();
            this.RangButton = new System.Windows.Forms.Button();
            this.LUButton = new System.Windows.Forms.Button();
            this.CramerButton = new System.Windows.Forms.Button();
            this.InverseButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UnitMatrixButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(12, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(860, 184);
            this.panel.TabIndex = 0;
            this.panel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel_ControlsChanged);
            this.panel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel_ControlsChanged);
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(194, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 290);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сведенияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // сведенияToolStripMenuItem
            // 
            this.сведенияToolStripMenuItem.Name = "сведенияToolStripMenuItem";
            this.сведенияToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.сведенияToolStripMenuItem.Text = "Сведения";
            this.сведенияToolStripMenuItem.Click += new System.EventHandler(this.сведенияToolStripMenuItem_Click);
            // 
            // CreateMatrixButton
            // 
            this.CreateMatrixButton.BackColor = System.Drawing.Color.MediumBlue;
            this.CreateMatrixButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateMatrixButton.ForeColor = System.Drawing.Color.White;
            this.CreateMatrixButton.Location = new System.Drawing.Point(12, 217);
            this.CreateMatrixButton.Name = "CreateMatrixButton";
            this.CreateMatrixButton.Size = new System.Drawing.Size(176, 35);
            this.CreateMatrixButton.TabIndex = 3;
            this.CreateMatrixButton.Text = "Создать Матрицу";
            this.CreateMatrixButton.UseVisualStyleBackColor = false;
            this.CreateMatrixButton.Click += new System.EventHandler(this.CreateMatrixButton_Click);
            // 
            // SumButton
            // 
            this.SumButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumButton.Location = new System.Drawing.Point(13, 297);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(40, 30);
            this.SumButton.TabIndex = 4;
            this.SumButton.Text = "A+B";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // SubButton
            // 
            this.SubButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubButton.Location = new System.Drawing.Point(56, 297);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(40, 30);
            this.SubButton.TabIndex = 5;
            this.SubButton.Text = "A-B";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // MultButton
            // 
            this.MultButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultButton.Location = new System.Drawing.Point(101, 297);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(40, 30);
            this.MultButton.TabIndex = 6;
            this.MultButton.Text = "A*B";
            this.MultButton.UseVisualStyleBackColor = true;
            this.MultButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // TransButton
            // 
            this.TransButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransButton.Location = new System.Drawing.Point(147, 297);
            this.TransButton.Name = "TransButton";
            this.TransButton.Size = new System.Drawing.Size(40, 30);
            this.TransButton.TabIndex = 7;
            this.TransButton.Text = "AT";
            this.TransButton.UseVisualStyleBackColor = true;
            this.TransButton.Click += new System.EventHandler(this.TransButton_Click);
            // 
            // MultNumButton
            // 
            this.MultNumButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultNumButton.Location = new System.Drawing.Point(13, 333);
            this.MultNumButton.Name = "MultNumButton";
            this.MultNumButton.Size = new System.Drawing.Size(83, 30);
            this.MultNumButton.TabIndex = 8;
            this.MultNumButton.Text = "A*k";
            this.MultNumButton.UseVisualStyleBackColor = true;
            this.MultNumButton.Click += new System.EventHandler(this.MultNumButton_Click);
            // 
            // PowButton
            // 
            this.PowButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowButton.Location = new System.Drawing.Point(101, 333);
            this.PowButton.Name = "PowButton";
            this.PowButton.Size = new System.Drawing.Size(86, 30);
            this.PowButton.TabIndex = 9;
            this.PowButton.Text = "A^k";
            this.PowButton.UseVisualStyleBackColor = true;
            this.PowButton.Click += new System.EventHandler(this.PowButton_Click);
            // 
            // DetButton
            // 
            this.DetButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetButton.Location = new System.Drawing.Point(13, 369);
            this.DetButton.Name = "DetButton";
            this.DetButton.Size = new System.Drawing.Size(83, 30);
            this.DetButton.TabIndex = 10;
            this.DetButton.Text = "Определитель";
            this.DetButton.UseVisualStyleBackColor = true;
            this.DetButton.Click += new System.EventHandler(this.DetButton_Click);
            // 
            // RangButton
            // 
            this.RangButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RangButton.Location = new System.Drawing.Point(101, 369);
            this.RangButton.Name = "RangButton";
            this.RangButton.Size = new System.Drawing.Size(87, 30);
            this.RangButton.TabIndex = 11;
            this.RangButton.Text = "Ранг";
            this.RangButton.UseVisualStyleBackColor = true;
            this.RangButton.Click += new System.EventHandler(this.RangButton_Click);
            // 
            // LUButton
            // 
            this.LUButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LUButton.Location = new System.Drawing.Point(14, 441);
            this.LUButton.Name = "LUButton";
            this.LUButton.Size = new System.Drawing.Size(175, 30);
            this.LUButton.TabIndex = 12;
            this.LUButton.Text = "LU-разложение";
            this.LUButton.UseVisualStyleBackColor = true;
            this.LUButton.Click += new System.EventHandler(this.LUButton_Click);
            // 
            // CramerButton
            // 
            this.CramerButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CramerButton.Location = new System.Drawing.Point(14, 477);
            this.CramerButton.Name = "CramerButton";
            this.CramerButton.Size = new System.Drawing.Size(174, 30);
            this.CramerButton.TabIndex = 13;
            this.CramerButton.Text = "Метод Крамера";
            this.CramerButton.UseVisualStyleBackColor = true;
            this.CramerButton.Click += new System.EventHandler(this.CramerButton_Click);
            // 
            // InverseButton
            // 
            this.InverseButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InverseButton.Location = new System.Drawing.Point(15, 405);
            this.InverseButton.Name = "InverseButton";
            this.InverseButton.Size = new System.Drawing.Size(174, 30);
            this.InverseButton.TabIndex = 14;
            this.InverseButton.Text = "Обратная матрица";
            this.InverseButton.UseVisualStyleBackColor = true;
            this.InverseButton.Click += new System.EventHandler(this.InverseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UnitMatrixButton
            // 
            this.UnitMatrixButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.UnitMatrixButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitMatrixButton.Location = new System.Drawing.Point(12, 258);
            this.UnitMatrixButton.Name = "UnitMatrixButton";
            this.UnitMatrixButton.Size = new System.Drawing.Size(174, 30);
            this.UnitMatrixButton.TabIndex = 15;
            this.UnitMatrixButton.Text = "Добавить единичную матрицу";
            this.UnitMatrixButton.UseVisualStyleBackColor = false;
            this.UnitMatrixButton.Click += new System.EventHandler(this.UnitMatrixButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.UnitMatrixButton);
            this.Controls.Add(this.InverseButton);
            this.Controls.Add(this.CramerButton);
            this.Controls.Add(this.LUButton);
            this.Controls.Add(this.RangButton);
            this.Controls.Add(this.DetButton);
            this.Controls.Add(this.PowButton);
            this.Controls.Add(this.MultNumButton);
            this.Controls.Add(this.TransButton);
            this.Controls.Add(this.MultButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.CreateMatrixButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(900, 560);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сведенияToolStripMenuItem;
        private System.Windows.Forms.Button CreateMatrixButton;
        internal System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button MultButton;
        private System.Windows.Forms.Button TransButton;
        private System.Windows.Forms.Button MultNumButton;
        private System.Windows.Forms.Button PowButton;
        private System.Windows.Forms.Button DetButton;
        private System.Windows.Forms.Button RangButton;
        private System.Windows.Forms.Button LUButton;
        private System.Windows.Forms.Button CramerButton;
        private System.Windows.Forms.Button InverseButton;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button UnitMatrixButton;
    }
}

