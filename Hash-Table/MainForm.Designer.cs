namespace Hash_Table
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MenuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(0, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(497, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdd,
            this.MenuView,
            this.MenuFind,
            this.MenuRecord,
            this.MenuClear,
            this.MenuDelete});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(497, 24);
            this.MainMenu.TabIndex = 101;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuAdd
            // 
            this.MenuAdd.Name = "MenuAdd";
            this.MenuAdd.Size = new System.Drawing.Size(58, 20);
            this.MenuAdd.Text = "Додати";
            this.MenuAdd.Click += new System.EventHandler(this.MenuAdd_Click);
            // 
            // MenuView
            // 
            this.MenuView.Name = "MenuView";
            this.MenuView.Size = new System.Drawing.Size(71, 20);
            this.MenuView.Text = "Перегляд";
            this.MenuView.Click += new System.EventHandler(this.MenuView_Click);
            // 
            // MenuFind
            // 
            this.MenuFind.Name = "MenuFind";
            this.MenuFind.Size = new System.Drawing.Size(58, 20);
            this.MenuFind.Text = "Пошук";
            this.MenuFind.Click += new System.EventHandler(this.MenuFind_Click);
            // 
            // MenuRecord
            // 
            this.MenuRecord.Name = "MenuRecord";
            this.MenuRecord.Size = new System.Drawing.Size(69, 20);
            this.MenuRecord.Text = "Зберегти";
            this.MenuRecord.Click += new System.EventHandler(this.MenuRecord_Click);
            // 
            // MenuDelete
            // 
            this.MenuDelete.Name = "MenuDelete";
            this.MenuDelete.Size = new System.Drawing.Size(71, 20);
            this.MenuDelete.Text = "Видалити";
            this.MenuDelete.Visible = false;
            this.MenuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(29, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 33);
            this.btnClose.TabIndex = 100;
            this.btnClose.Text = "Вихід";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MenuClear
            // 
            this.MenuClear.Name = "MenuClear";
            this.MenuClear.Size = new System.Drawing.Size(72, 20);
            this.MenuClear.Text = "Очистити";
            this.MenuClear.Click += new System.EventHandler(this.MenuClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 275);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.btnClose);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash-Table";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuRecord;
        private System.Windows.Forms.ToolStripMenuItem MenuFind;
        private System.Windows.Forms.ToolStripMenuItem MenuView;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
        private System.Windows.Forms.ToolStripMenuItem MenuClear;
    }
}

