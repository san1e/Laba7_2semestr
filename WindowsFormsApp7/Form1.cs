using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        Graphics g;
        int BallRadius = 20;
        int cx = 100;
        int cy = 100;
        int freqX = 5;
        int freqY = 4;
        int ampl = 250;
        int t;
        public Form1()
        {
            InitializeComponent();
            timer1.Start(); 
            timer1.Interval = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            cx = (Width - BallRadius)/2  + (int)(Math.Sin(t * freqX * 0.1) * ampl); // Горизонтальна позиція
            cy = (Height - BallRadius)/2  + (int)(Math.Cos(t * freqY * 0.1) * ampl); // Вертикальна позиція
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.Purple),cx,cy,50,50);
        }

    }
}
