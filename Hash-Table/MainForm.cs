using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash_Table
{
    public partial class MainForm : Form
    {
        public struct Data
        {
            public string author { get; private set; }
            public int count { get; private set; }

            public Data(string author, int count)
            {
                this.author = author;
                this.count = count;
            }
        }

        private delegate bool IsEmpty(string str);
        IsEmpty isEmpty = String.IsNullOrWhiteSpace;

        public Dictionary<int, Dictionary<int, Data>> hash_table = new Dictionary<int, Dictionary<int, Data>>();
        public System.Collections.ArrayList formElement = new System.Collections.ArrayList();

        int indexWidth = 0;
        int indexHight = 0;        

        public MainForm()
        {
            InitializeComponent();
            this.saveFileDialog.Filter = "Текстові файли(*.txt)|*.txt|Всі файли(*.*)|*.*";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OutputAdd();
        }

        private void ClearForm()
        {
            if (formElement.Count == 0)
                return;
            for (int i = formElement.Count - 1; i >= 0; i--)
            {
                this.Controls.Remove(formElement[i] as Control);
                formElement.RemoveAt(i);
            }
        }

        private void MainObjects()
        {
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIndex.Location = new System.Drawing.Point(188, 75);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(269, 26);
            this.textBoxIndex.TabIndex = 1;
            this.textBoxIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthor.Location = new System.Drawing.Point(188, 124);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(269, 26);
            this.textBoxAuthor.TabIndex = 2;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCount.Location = new System.Drawing.Point(188, 174);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(269, 26);
            this.textBoxCount.TabIndex = 3;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Шифр книги:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прізвище \r\nавтора:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кількість \r\nпримірників:";
            
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxIndex);
            
            this.formElement.Add(this.label3);
            this.formElement.Add(this.label2);
            this.formElement.Add(this.label1);
            this.formElement.Add(this.textBoxCount);
            this.formElement.Add(this.textBoxAuthor);
            this.formElement.Add(this.textBoxIndex);
        }

        private void OutputAdd()
        {
            MainObjects();
            this.labelTitle.Text = "Додати запис";
            this.btnAdd = new System.Windows.Forms.Button();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(371, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 33);
            this.btnAdd.TabIndex = 100;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.Controls.Add(this.btnAdd);

            this.formElement.Add(this.btnAdd);
        }

        private void OutputView()
        {
            MainObjects();
            this.labelTitle.Text = "Перегляд таблиці";

            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();            
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(355, 225);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 33);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Наступний";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Enabled = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(197, 225);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 33);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Попередній";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Enabled = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.textBoxIndex.ReadOnly = true;
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxCount.ReadOnly = true;

            this.textBoxIndex.TabStop = false;
            this.textBoxAuthor.TabStop = false;
            this.textBoxCount.TabStop = false;

            this.textBoxIndex.BackColor = Color.White;
            this.textBoxAuthor.BackColor = Color.White;
            this.textBoxCount.BackColor = Color.White;

            this.textBoxIndex.BorderStyle = BorderStyle.None;
            this.textBoxAuthor.BorderStyle = BorderStyle.None;
            this.textBoxCount.BorderStyle = BorderStyle.None;

            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);

            this.formElement.Add(this.btnBack);
            this.formElement.Add(this.btnNext);
        }

        private void OutputFind()
        {
            MainObjects();
            this.labelTitle.Text = "Пошук";

            this.textBoxAuthor.ReadOnly = true;
            this.textBoxCount.ReadOnly = true;

            this.btnFind = new System.Windows.Forms.Button();
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(355, 225);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(130, 33);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Знайти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);

            this.Controls.Add(this.btnFind);

            this.formElement.Add(this.btnFind);
        }

        private static int HashCode(int key)
        {
            int count = 0;
            int result = 0;
            while (key > 0)
            {
                result += key % 10;
                key = (key - key % 10) / 10;
                count++;
            }
            return (result / count);
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < (char)Keys.D0 || e.KeyChar > (char)Keys.D9) && e.KeyChar != (char)Keys.Back)
                e.KeyChar = (char)0;
        }

        private void TextBox_Clear()
        {
            textBoxIndex.Clear();
            textBoxAuthor.Clear();
            textBoxCount.Clear();
        }

        private bool TextBox_FillAll()
        {
            string textIndex = this.textBoxIndex.Text;
            string textAuthor = this.textBoxAuthor.Text;
            string textCount = this.textBoxCount.Text;
            if (isEmpty(textIndex) || isEmpty(textAuthor) || isEmpty(textCount))
            {
                MessageBox.Show("Заповніть, будь ласка, всі поля.",
                    "Попередження!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            return !(isEmpty(textIndex) || isEmpty(textAuthor) || isEmpty(textCount));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TextBox_FillAll())
                return;
            int index = Int32.Parse(this.textBoxIndex.Text);
            string author = this.textBoxAuthor.Text;
            int count = Int32.Parse(this.textBoxCount.Text);
            int hash_code = HashCode(index);

            try
            {
                if (hash_table.ContainsKey(hash_code))
                {
                    hash_table[hash_code].Add(index, new Data(author, count));
                }
                else
                {
                    Dictionary<int, Data> value = new Dictionary<int, Data>();
                    value.Add(index, new Data(author, count));
                    hash_table.Add(hash_code, value);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show(String.Format("Елемент з ключем \"{0}\" вже був доданий!", index),
                    "Попередження!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            TextBox_Clear();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Dictionary<int, Data> value = hash_table.ElementAt(indexHight).Value;

            indexWidth++;
            if (indexWidth == value.Count)
            {
                indexWidth = 0;
                indexHight++;
                value = hash_table.ElementAt(indexHight).Value;
            }
            if (indexHight == hash_table.Count - 1 && indexWidth == value.Count -1)
            {
                this.btnNext.Enabled = false;
            }

            this.textBoxIndex.Text = value.Keys.ElementAt(indexWidth).ToString();
            this.textBoxAuthor.Text = value.Values.ElementAt(indexWidth).author;
            this.textBoxCount.Text = value.Values.ElementAt(indexWidth).count.ToString();

            this.btnBack.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dictionary<int, Data> value = hash_table.ElementAt(indexHight).Value;
            
            if (indexWidth == 0)
            {
                indexHight--;
                value = hash_table.ElementAt(indexHight).Value;
                indexWidth = value.Count - 1;
            }
            else indexWidth--;
            if (indexHight == 0 && indexWidth == 0)
            {
                this.btnBack.Enabled = false;
            }

            this.textBoxIndex.Text = value.Keys.ElementAt(indexWidth).ToString();
            this.textBoxAuthor.Text = value.Values.ElementAt(indexWidth).author;
            this.textBoxCount.Text = value.Values.ElementAt(indexWidth).count.ToString();

            this.btnNext.Enabled = true;
        }
        
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(isEmpty(this.textBoxIndex.Text))
            {
                MessageBox.Show("Заповніть, будь ласка, всі поля.",
                    "Попередження!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            int indexCode = Int32.Parse(this.textBoxIndex.Text);
            if(hash_table.ContainsKey(HashCode(indexCode)) && hash_table[HashCode(indexCode)].ContainsKey(indexCode))
            {
                Dictionary<int, Data> value = hash_table[HashCode(indexCode)];
                this.textBoxAuthor.Text = value[indexCode].author;
                this.textBoxCount.Text = value[indexCode].count.ToString();
            }
            else
            {
                MessageBox.Show(String.Format("Шифр книги: {0} - відсутній", indexCode),
                    "Інформація",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                TextBox_Clear();
            }
        }

        private void MenuAdd_Click(object sender, EventArgs e)
        {
            this.MenuDelete.Visible = false;
            ClearForm();
            OutputAdd();
        }

        private void MenuView_Click(object sender, EventArgs e)
        {
            if (hash_table.Count > 0)
            {
                ClearForm();
                OutputView();
                this.textBoxIndex.Text = hash_table.ElementAt(indexHight).Value.Keys.ElementAt(indexWidth).ToString();
                this.textBoxAuthor.Text = hash_table.ElementAt(indexHight).Value.Values.ElementAt(indexWidth).author;
                this.textBoxCount.Text = hash_table.ElementAt(indexHight).Value.Values.ElementAt(indexWidth).count.ToString();
                this.MenuDelete.Visible = true;
                if(hash_table.Count > 1)
                {
                    this.btnNext.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Хеш-таблиця - пуста.",
                    "Інформація",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void MenuRecord_Click(object sender, EventArgs e)
        {
            this.MenuDelete.Visible = false;
            if (hash_table.Count == 0)
            {
                MessageBox.Show("Хеш-таблиця - пуста.",
                    "Інформація",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog.FileName;
            System.IO.File.Create(filename).Close();
            foreach(var hight in hash_table)
            {
                foreach(var width in hight.Value)
                {
                    string[] data =
                    {
                        "Шифр книги: " + width.Key,
                        "Прізвище автора: " + width.Value.author,
                        "Кількість примірників: " + width.Value.count,
                        "\n"
                    };
                    System.IO.File.AppendAllLines(filename, data);
                }
            }
            MessageBox.Show("Файл збережено",
                "Інформація",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MenuFind_Click(object sender, EventArgs e)
        {
            this.MenuDelete.Visible = false;
            if (hash_table.Count == 0)
            {
                MessageBox.Show("Хеш-таблиця - пуста.",
                    "Інформація",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                ClearForm();
                OutputFind();
            }
        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            int key = Int32.Parse(this.textBoxIndex.Text);
            Dictionary<int, Data> value = hash_table[HashCode(key)];
            value.Remove(key);
            if (hash_table.ElementAt(indexHight).Value.Count == 0)
            {
                hash_table.Remove(HashCode(key));
            }
            if (hash_table.Count == 0)
            {
                MessageBox.Show("Хеш-таблиця - пуста.",
                    "Інформація",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.MenuDelete.Visible = false;
                ClearForm();
                OutputAdd();
                return;
            }
            this.textBoxIndex.Text = hash_table.ElementAt(0).Value.Keys.ElementAt(0).ToString();
            this.textBoxAuthor.Text = hash_table.ElementAt(0).Value.Values.ElementAt(0).author;
            this.textBoxCount.Text = hash_table.ElementAt(0).Value.Values.ElementAt(0).count.ToString();
            this.btnBack.Enabled = false;
        }
    }
}
