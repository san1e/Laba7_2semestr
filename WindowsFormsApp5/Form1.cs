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
   
        int Ear1X = 380;
        int Ear1Y = 390;
        int Ear2X = 250;
        int Ear2Y = 450;
        int Ear3X = 380;
        int Ear3Y = 540;

        int Leg1X= 130;
        int Leg1Y= 600;
        int Leg2X= 320;
        int Leg2Y= 600;

        int rad = 150;
        int HobotX = 370;
        int HobotY = 450;

        bool isMovingLeft = false;
        bool isEarUp = false;
        bool isHobotUp = false;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 250; 
            timer1.Start();
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
            if (isEarUp)
            {
                Point[] points =
                {
                    new Point(Ear1X,Ear1Y),
                    new Point(Ear2X,Ear2Y),
                    new Point(Ear3X,Ear3Y)
                };
                g.FillPolygon(new SolidBrush(Color.Plum), points);
                g.DrawPolygon(new Pen(Color.Purple), points);
            }
            else
            {
                Point[] points =
                {
                    new Point(Ear1X,Ear1Y),
                    new Point(Ear2X,Ear2Y-50),
                    new Point(Ear3X-50,Ear3Y)
                };
                g.FillPolygon(new SolidBrush(Color.Plum), points);
                g.DrawPolygon(new Pen(Color.Purple), points);
            }
        }
        void DrLegs()
        {
            g.FillRectangle(new SolidBrush(Color.PowderBlue),Leg1X,Leg1Y,50,100);
            g.DrawRectangle(new Pen(Color.RoyalBlue),Leg1X,Leg1Y,50,100);

            g.FillRectangle(new SolidBrush(Color.PowderBlue), Leg2X, Leg2Y, 50, 100);
            g.DrawRectangle(new Pen(Color.RoyalBlue), Leg2X, Leg2Y, 50, 100);
        }

        void DrHobot()
        {
            if (isHobotUp)
            {
                g.DrawArc(new Pen(Color.LightSteelBlue, 40), HobotX, HobotY , rad, rad, 0, -180);
            }
            else
            {
                g.DrawArc(new Pen(Color.LightSteelBlue, 40), HobotX, HobotY, rad, rad, 0+20, -150);
            }

        }
        void DrElephant()
        {
            DrHobot();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMovingLeft)
            {
                BodyX -= 10;
                HeadX -= 10;
                Eye1X -= 10;
                Eye2X -= 10;
                Eye3X -= 10;
                Ear1X -= 10;
                Ear2X -= 10;
                Ear3X -= 10;
                Leg1X -= 10;
                Leg2X -= 10;
                HobotX -= 10;
            }
            else
            {
                BodyX += 10;
                HeadX += 10;
                Eye1X += 10;
                Eye2X += 10;
                Eye3X += 10;
                Ear1X += 10;
                Ear2X += 10;
                Ear3X += 10;
                Leg1X += 10;
                Leg2X += 10;
                HobotX += 10;
            }

            if (BodyX <= 0 || BodyX + 300 >= Width)
            {
                isMovingLeft = !isMovingLeft;
            }

            isEarUp = !isEarUp;
            isHobotUp = !isHobotUp;

            Invalidate();
        }
    }
}
