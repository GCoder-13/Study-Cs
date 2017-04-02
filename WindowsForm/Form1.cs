using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class MainForm : Form
    {
        int count;
        Random rnd;
        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void ToolStripMenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripMenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Grimm","About");
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(Count.Text);
            count++;
            Count.Text = Convert.ToString(count);
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(Count.Text);
            count--;
            if (count < 0)
                count = 0;
            Count.Text = Convert.ToString(count);
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            Count.Text = Convert.ToString(0);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            int n = rnd.Next(Convert.ToInt32(valueMin.Value), Convert.ToInt32(valueMax.Value) + 1);
            lRand.Text = n.ToString();
            if(checkBoxNRepead.Checked)
            {
                int i=0;
                while (tBRand.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(valueMin.Value), Convert.ToInt32(valueMax.Value) + 1);
                    i++;
                    if (i > valueMax.Maximum)
                        break;
                }
                if (i <= valueMax.Maximum)
                    tBRand.AppendText(n + "\n");
            }
            else tBRand.AppendText(n + "\n");

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            lRand.Text = Convert.ToString(0);
            tBRand.Clear();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tBRand.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Total Commander\\TOTALCMD64.EXE");
        }
    }
}
