using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace TurtleGraphics
{
    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;

            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }

        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Rotate(130);
            for (int i = 1; i<=6; i++)
            {
                Turtle.Delay = 100;
                Turtle.Rotate(60);
                Turtle.Forward(100);
                
            }
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            Turtle.Rotate(120);
            Turtle.PenColor = Color.Green;

            for (int i = 1; i <= 5; i++)

            {
                Turtle.Delay = 200;
                Turtle.Rotate(144);
                Turtle.Forward(200);
            }
        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            int forward = 10;
            for (int i = 1; i <= 20; i++)
            {
                forward += 10;
                Turtle.Delay = 100;
                Turtle.Rotate(60);
                Turtle.Forward(forward);
            }
        }

        private void buttonSun_Click(object sender, EventArgs e)
        {
            Turtle.Rotate(100);
            Turtle.PenUp();
            Turtle.Forward(100);
            Turtle.PenDown();

            for(int i= 1; i <= 36; i++)
            {

                Turtle.Delay = 100;
                Turtle.Rotate(170);
                Turtle.Forward(350);
            }
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            int forward = 10;
            Turtle.PenColor = Color.Red;
            for (int i = 1; i <= 22; i++)
            {
                Turtle.Delay = 100;
                forward += 10;
                Turtle.Rotate(120);
                Turtle.Forward(forward);
            }
        }
    }
}
