using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiQuadratic_equation
{
    public partial class EquationForm : Form
    {
        delegate bool IsEmpty(string str);
        IsEmpty isEmpty = String.IsNullOrEmpty;
        public EquationForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != '.' && 
                e.KeyChar != (char)8 && e.KeyChar != '-')
                e.KeyChar = (char)0;
            else if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(isEmpty(textBoxA.Text) && isEmpty(textBoxB.Text) && isEmpty(textBoxC.Text))
            {
                MessageBox.Show("Заповніть всі поля",
                    "Попередження",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            double a = Double.Parse(textBoxA.Text);
            double b = Double.Parse(textBoxB.Text);
            double c = Double.Parse(textBoxC.Text);

            double D = b * b - 4 * a * c;
            if(D < 0)
            {
                MessageBox.Show("Рівняння не має розв\'язку",
                    "Відповідь",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            double x1 = (-b - Math.Sqrt(D)) / (2 * a);
            double x2 = (-b + Math.Sqrt(D)) / (2 * a);
            string message = "Корені рівняння: ";
            bool sw = false;

            if(x1 > 0)
            {
                sw = true;
                x1 = Math.Sqrt(x1);
                message += String.Format("{0}, {1},", x1, -x1);
            }
            if (x2 > 0)
            {
                sw = true;
                x2 = Math.Sqrt(x2);
                message += String.Format("{0}, {1}", x2, -x2);
            }
            if(x1 == 0 || x2 == 0)
            {
                sw = true;
                message += ", 0";
            }

            if (sw)
            {
                MessageBox.Show(message,
                "Відповідь",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else MessageBox.Show(message + "коренів не має",
                "Відповідь",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
