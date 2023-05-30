using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        private Timer timer;
        private float amplitudeX; // Амплітуда горизонтальних коливань
        private float amplitudeY; // Амплітуда вертикальних коливань
        private float frequencyX; // Частота горизонтальних коливань
        private float frequencyY; // Частота вертикальних коливань
        private float angle;

        public Form1()
        {
            InitializeComponent();

            // Ініціалізація параметрів коливань
            amplitudeX = 200;
            amplitudeY = 100;
            frequencyX = 5;
            frequencyY = 3;

            timer = new Timer();
            timer.Interval = 50; // Інтервал оновлення в мілісекундах
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            angle += 0.01f; // Зміщення кута кожного кроку таймера

            // Обчислення позиції кульки на основі гармонічних коливань
            int x = (int)(amplitudeX * Math.Cos(frequencyX * angle)) + ClientSize.Width/2;
            int y = (int)(amplitudeY * Math.Sin(frequencyY * angle)) + ClientSize.Height/2;

            // Оновлення положення кульки
            pictureBox1.Location = new Point(x, y);

            // Перемалювання форми
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Малювання кульки
            int ballSize = 50;
            int x = pictureBox1.Location.X - ballSize;
            int y = pictureBox1.Location.Y - ballSize;
            g.FillEllipse(Brushes.Red, x, y, ballSize, ballSize);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
