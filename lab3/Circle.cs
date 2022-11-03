using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Circle : Figure
    {

        private int radius { get; }
        public Circle(int centerX, int centerY, int radius) : base(centerX, centerY)
        {
            this.radius = radius;
        }


        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, x,y,radius,radius);
        }

        public override void HideDrawingBackground()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();

            graphics.DrawEllipse(new Pen(Form1.ActiveForm.BackColor), x, y, radius, radius);
        }
       
    }
}
