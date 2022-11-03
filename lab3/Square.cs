using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Square : Figure
    {

        private int sideLength { get; }

        
        public Square(int centerX, int centerY, int size) : base(centerX, centerY)
        {
            this.sideLength = size;
        }

        public override void DrawBlack()
        {

            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawRectangle(Pens.Black, x, y, sideLength, sideLength);
        }

        public override void HideDrawingBackground()
        {

            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawRectangle(new Pen(Form1.ActiveForm.BackColor), x, y, sideLength, sideLength);
        }
        
    }
}
