using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pr12_3
{
    public partial class Robot : Form
    {
        public Robot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                robot robot1 = new robot();
                robot robot2 = new robot();
                robot robot3 = new robot();
                Random rn = new Random();
                int b = rn.Next(0, 100);
                robot1.min(b);
                robot1.kollife = Convert.ToInt32(textBox1.Text);
                label1.Text = " Кол-во жизней робота1 в начале игры " + robot1.kollife;
                robot2.kollife = Convert.ToInt32(textBox2.Text);
                label6.Text = " Кол-во жизней робота2 в начале игры" + robot2.kollife;
                robot3.kollife = Convert.ToInt32(textBox3.Text);
                label7.Text = "Кол-во жизней робота3 в начале игры " + robot3.kollife;
                int a = robot1.kollife;
                robot1.min(robot1.kollife);
                label2.Text = "Кол-во жизней робота1 в конце игры " + Convert.ToString(robot1.getlife());
                robot2.kol(a, robot1.kollife);
                label8.Text = " Кол-во жизней робота2 в конце игры" + Convert.ToString(robot2.getlife());
                robot3.kol(a, robot1.kollife);
                label9.Text = " Кол-во жизней робота3 в конце игры" + Convert.ToString(robot3.getlife());
            }
            catch
            {
                MessageBox.Show("Ошибка при вводе данных", "Ошибка");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
