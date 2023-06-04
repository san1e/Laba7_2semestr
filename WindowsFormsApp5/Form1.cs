using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Graphics g;
        int BodyX = 100;
        int BodyY = 400;

        int HeadX = 300;
        int HeadY = 360;

        int Eye1X = 410;
        int Eye1Y = 400;
        int Eye2X = 425;
        int Eye2Y = 410;
        int Eye3X = 440;
        int Eye3Y = 420;
   
        int EarX = 0;
        int EarY = 0;

        int Leg1X= 130;
        int Leg1Y= 600;
        int Leg2X= 320;
        int Leg2Y= 600;
        public Form1()
        {
            InitializeComponent();

        }
        void DrBody()
        {
            g.FillEllipse(new SolidBrush(Color.Lavender), BodyX, BodyY, 300, 250);
            g.DrawEllipse(new Pen(Color.Gray), BodyX, BodyY, 300, 250);
        }
        void DrHead()
        {
            g.FillEllipse(new SolidBrush(Color.Pink), HeadX, HeadY, 170, 170);
            g.DrawEllipse(new Pen(Color.Plum), HeadX, HeadY, 170, 170);
        }

        void DrEyes()
        {
            g.FillEllipse(new SolidBrush(Color.White),Eye1X,Eye1Y,50,50);
            g.DrawEllipse(new Pen(Color.Black),Eye1X,Eye1Y,50,50);

            g.FillEllipse(new SolidBrush(Color.Black), Eye2X, Eye2Y, 30, 30);
            g.DrawEllipse(new Pen(Color.Black), Eye2X, Eye2Y, 30, 30);

            g.FillEllipse(new SolidBrush(Color.White), Eye3X, Eye3Y, 10, 10);
            g.DrawEllipse(new Pen(Color.Black), Eye3X, Eye3Y, 10, 10);
        }
        void DrEar()
        {
            Point[] points =
            {
                new Point(340,380),
                new Point(250,450),
                new Point(350,580)
            };
            g.FillPolygon(new SolidBrush(Color.Purple),points);
        }
        void DrLegs()
        {
            g.FillRectangle(new SolidBrush(Color.PowderBlue),Leg1X,Leg1Y,50,100);
            g.DrawRectangle(new Pen(Color.RoyalBlue),Leg1X,Leg1Y,50,100);

            g.FillRectangle(new SolidBrush(Color.PowderBlue), Leg2X, Leg2Y, 50, 100);
            g.DrawRectangle(new Pen(Color.RoyalBlue), Leg2X, Leg2Y, 50, 100);
        }
        void DrElephant()
        {
            DrLegs();
            DrBody();
            DrHead();
            DrEyes();
            DrEar();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            DrElephant();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
