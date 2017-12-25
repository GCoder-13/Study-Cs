using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics g = Graphics.FromImage(bmp);

            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, new Rectangle(new Point(150, 100), new Size(200, 150)));
            g.DrawLine(pen, new Point(150, 100), new Point(200, 50));
            g.DrawLine(pen, new Point(350, 100), new Point(300, 50));
            g.DrawLine(pen, new Point(200, 50), new Point(300, 50));
            g.DrawRectangle(pen, new Rectangle(new Point(225, 150), new Size(50, 50)));

            picture.Image = bmp;
        }
    }
}
