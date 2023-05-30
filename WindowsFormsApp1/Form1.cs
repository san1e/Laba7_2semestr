using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point[] parallelogramPoints =
            {
                new Point(50, 100),
                new Point(25, 200),
                new Point(225,200),
                new Point(250,100)
            };
            Brush parallelogramBrush = new SolidBrush(Color.Blue);
            g.FillPolygon(parallelogramBrush, parallelogramPoints);

            Point[] trap =
            {
                new Point(300,100),
                new Point(300,200),
                new Point(450,200),
                new Point(350,100)
            };
            Brush trapBrush = new SolidBrush(Color.Red);
            g.FillPolygon(trapBrush, trap);

            Brush elBrush = new SolidBrush(Color.Green);
            g.FillEllipse(elBrush, 50, 250, 100, 100);


            g.FillPie(new SolidBrush(Color.Purple),300,250,100,100,180,180); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
