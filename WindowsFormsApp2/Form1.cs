using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, 10, 0, 1000, 1000);
            g.DrawRectangle(Pens.Black, 10, 0, 250, 250);//1
            g.DrawRectangle(Pens.Black, 260, 0, 500, 250);//2
            g.DrawRectangle(Pens.Black, 760, 0, 250, 250);//3
            g.DrawRectangle(Pens.Black, 10, 250, 250, 500);//4
            g.DrawRectangle(Pens.Black, 760, 250, 250, 500);//5
            g.DrawRectangle(Pens.Black, 10, 750, 250, 250);//6
            g.DrawRectangle(Pens.Black, 260, 750, 500, 250);//7
                                                            
            g.DrawLine(Pens.Black, 10, 250,260,0);//left-right
            g.DrawLine(Pens.Black,10,500,510,0);//left-right
            g.DrawLine(Pens.Black, 260, 500, 510, 250);//left-right
            g.DrawLine(Pens.Black, 510, 750, 760, 500);//left-right
            g.DrawLine(Pens.Black, 510, 1000, 1010, 500);//left-right
            g.DrawLine(Pens.Black, 760, 1000, 1010, 750);//left-right

            g.DrawLine(Pens.Black, 760, 0, 1010, 250);//right-left
            g.DrawLine(Pens.Black, 510, 0, 1010, 500);//right-left
            g.DrawLine(Pens.Black, 510, 250, 760, 500);//right-left
            g.DrawLine(Pens.Black, 260, 500, 510, 750);//right-left
            g.DrawLine(Pens.Black, 10, 500, 510, 1000);//right-left
            g.DrawLine(Pens.Black, 10, 750, 250, 1000);//right-left
        }
    }
}
