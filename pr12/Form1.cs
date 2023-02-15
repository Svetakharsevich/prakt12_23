using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr11_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Graphics g = pictureBox1.CreateGraphics();
                Triangles figure = new Triangles();
                double x1 = Convert.ToDouble(textBox1.Text);
                double y1 = Convert.ToDouble(textBox2.Text);
                double x2 = Convert.ToDouble(textBox3.Text);
                double y2 = Convert.ToDouble(textBox4.Text);
                double x3 = Convert.ToDouble(textBox5.Text);
                double y3 = Convert.ToDouble(textBox6.Text);
                Point[] points = new Point[3];
                points[0].X = ((int)x1); points[0].Y = ((int)y1);
                points[1].X = ((int)x2); points[1].Y = ((int)y2);
                points[2].X = ((int)x3); points[2].Y = ((int)y3);
                label7.Text = "Площадь = " + figure.Ss(x1, y1, x2, y2, x3, y3);
                label8.Text = "Периметр = " + figure.P(x1, y1, x2, y2, x3, y3);
                label9.Text = "Точка пересечении медианы x0 = " + figure.IntrtsectionX0(x1, x2, x3);
                label10.Text = "Точка пересечении медианы y0 = " + figure.IntrtsectionY0(y1, y2, y3);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics grfx = Graphics.FromImage(bmp))
                {
                    
                    grfx.Clear(Color.White);
                    grfx.DrawPolygon(Pens.Black, points);
                }
                pictureBox1.Image = bmp;
            }
            catch
            {
                MessageBox.Show("Ошибка при вводе данных", "Ошибка");
            }
        }
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
