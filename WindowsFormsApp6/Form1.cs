using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private float x, y; 
        private float dx, dy; 
        private float frequencyX, frequencyY; 
        private const float amplitude = 50; 

        
        public Form1()
        {
            InitializeComponent();
            x = this.Width / 2;
            y = this.Height / 2;
            dx = 0;
            dy = 0;
            frequencyX = 0.02f; // Частота коливань по горизонталі
            frequencyY = 0.03f; // Частота коливань по вертикалі

            timer = new Timer();
            timer.Interval = 10; // Інтервал оновлення анімації (в мілісекундах)
            timer.Tick += timer1_Tick;
            timer.Start();
            Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Малюємо кульку
            g.FillEllipse(Brushes.Red, x - 10, y - 10, 20, 20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            dx = amplitude * (float)Math.Sin(frequencyX * DateTime.Now.TimeOfDay.TotalMilliseconds);
            dy = amplitude * (float)Math.Sin(frequencyY * DateTime.Now.TimeOfDay.TotalMilliseconds);

            // Переміщення кульки відповідно до зміщень
            x = this.Width / 2 + dx;
            y = this.Height / 2 + dy;
        }

    }
}
