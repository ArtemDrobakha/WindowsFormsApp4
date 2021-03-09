using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Point[4];
            p[0] = new Point(300, 50);
            p[1] = new Point(300, 200);
            p[2] = new Point(500, 200);
            p[3] = new Point(500, 50);
            color = new SolidBrush(Color.Green);
        }

        Graphics g;
        Point[] p;
        Brush color;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();

            // тло
            g.Clear(Color.Gray);

            // залити контур фоном
            g.FillPolygon(color, p);

        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            this.Text = Convert.ToString(e.Location.X + " " + e.Location.Y);
            if (e.Location.X > 300 && e.Location.X < 500 && e.Location.Y > 50 && e.Location.Y < 200)
            {
                if (listBox1.Text == "Blue")
                {
                    color = new SolidBrush(Color.Blue);
                }
                if (listBox1.Text == "Yellow")
                {
                    color = new SolidBrush(Color.Yellow);
                }
                if (listBox1.Text == "Red")
                {
                    color = new SolidBrush(Color.Red);
                }
                // залити контур фоном
                g.FillPolygon(color, p);
            }
            else
            {
                color = new SolidBrush(Color.Green);
                if (g != null)
                {
                    g.FillPolygon(color, p);
                }
            }
        }
    }
}
