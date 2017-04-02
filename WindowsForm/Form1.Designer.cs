namespace WindowsForm
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TabPageCount = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Count = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.tabPageRand = new System.Windows.Forms.TabPage();
            this.checkBoxNRepead = new System.Windows.Forms.CheckBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tBRand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.lRand = new System.Windows.Forms.Label();
            this.valueMax = new System.Windows.Forms.NumericUpDown();
            this.valueMin = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.TabPageCount.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageRand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueMin)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ToolStripMenuExit
            // 
            this.ToolStripMenuExit.Name = "ToolStripMenuExit";
            this.ToolStripMenuExit.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuExit.Text = "Выход";
            this.ToolStripMenuExit.Click += new System.EventHandler(this.ToolStripMenuExit_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuAbout});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // ToolStripMenuAbout
            // 
            this.ToolStripMenuAbout.Name = "ToolStripMenuAbout";
            this.ToolStripMenuAbout.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuAbout.Text = "О програме";
            this.ToolStripMenuAbout.Click += new System.EventHandler(this.ToolStripMenuAbout_Click);
            // 
            // TabPageCount
            // 
            this.TabPageCount.Controls.Add(this.tabPage1);
            this.TabPageCount.Controls.Add(this.tabPageRand);
            this.TabPageCount.Controls.Add(this.tabPage2);
            this.TabPageCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPageCount.Location = new System.Drawing.Point(0, 24);
            this.TabPageCount.Name = "TabPageCount";
            this.TabPageCount.SelectedIndex = 0;
            this.TabPageCount.Size = new System.Drawing.Size(504, 251);
            this.TabPageCount.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Count);
            this.tabPage1.Controls.Add(this.ButtonReset);
            this.tabPage1.Controls.Add(this.ButtonMinus);
            this.tabPage1.Controls.Add(this.ButtonPlus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Count";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(214, 91);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(20, 22);
            this.Count.TabIndex = 3;
            this.Count.Text = "0";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonReset.Location = new System.Drawing.Point(283, 85);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 35);
            this.ButtonReset.TabIndex = 2;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMinus.Location = new System.Drawing.Point(194, 153);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(75, 35);
            this.ButtonMinus.TabIndex = 1;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPlus.Location = new System.Drawing.Point(194, 24);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(75, 35);
            this.ButtonPlus.TabIndex = 0;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // tabPageRand
            // 
            this.tabPageRand.Controls.Add(this.checkBoxNRepead);
            this.tabPageRand.Controls.Add(this.buttonCopy);
            this.tabPageRand.Controls.Add(this.buttonClear);
            this.tabPageRand.Controls.Add(this.tBRand);
            this.tabPageRand.Controls.Add(this.label2);
            this.tabPageRand.Controls.Add(this.label1);
            this.tabPageRand.Controls.Add(this.buttonGo);
            this.tabPageRand.Controls.Add(this.lRand);
            this.tabPageRand.Controls.Add(this.valueMax);
            this.tabPageRand.Controls.Add(this.valueMin);
            this.tabPageRand.Location = new System.Drawing.Point(4, 22);
            this.tabPageRand.Name = "tabPageRand";
            this.tabPageRand.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRand.Size = new System.Drawing.Size(496, 225);
            this.tabPageRand.TabIndex = 1;
            this.tabPageRand.Text = "Random";
            this.tabPageRand.UseVisualStyleBackColor = true;
            // 
            // checkBoxNRepead
            // 
            this.checkBoxNRepead.AutoSize = true;
            this.checkBoxNRepead.Location = new System.Drawing.Point(23, 27);
            this.checkBoxNRepead.Name = "checkBoxNRepead";
            this.checkBoxNRepead.Size = new System.Drawing.Size(76, 17);
            this.checkBoxNRepead.TabIndex = 9;
            this.checkBoxNRepead.Text = "No repead";
            this.checkBoxNRepead.UseVisualStyleBackColor = true;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCopy.Location = new System.Drawing.Point(45, 158);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(102, 38);
            this.buttonCopy.TabIndex = 8;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(187, 158);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(103, 38);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // tBRand
            // 
            this.tBRand.Location = new System.Drawing.Point(401, 21);
            this.tBRand.Multiline = true;
            this.tBRand.Name = "tBRand";
            this.tBRand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBRand.Size = new System.Drawing.Size(72, 112);
            this.tBRand.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(136, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "От";
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGo.Location = new System.Drawing.Point(333, 158);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(123, 38);
            this.buttonGo.TabIndex = 3;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // lRand
            // 
            this.lRand.AutoSize = true;
            this.lRand.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRand.Location = new System.Drawing.Point(329, 65);
            this.lRand.Name = "lRand";
            this.lRand.Size = new System.Drawing.Size(20, 22);
            this.lRand.TabIndex = 2;
            this.lRand.Text = "0";
            this.lRand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueMax
            // 
            this.valueMax.Location = new System.Drawing.Point(187, 95);
            this.valueMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueMax.Name = "valueMax";
            this.valueMax.Size = new System.Drawing.Size(88, 20);
            this.valueMax.TabIndex = 1;
            this.valueMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valueMin
            // 
            this.valueMin.Location = new System.Drawing.Point(187, 43);
            this.valueMin.Name = "valueMin";
            this.valueMin.Size = new System.Drawing.Size(88, 20);
            this.valueMin.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(496, 225);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 275);
            this.Controls.Add(this.TabPageCount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabPageCount.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageRand.ResumeLayout(false);
            this.tabPageRand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueMin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuExit;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuAbout;
        private System.Windows.Forms.TabControl TabPageCount;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageRand;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label lRand;
        private System.Windows.Forms.NumericUpDown valueMax;
        private System.Windows.Forms.NumericUpDown valueMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBRand;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckBox checkBoxNRepead;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
    }
}

