using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Rhomb : Figure
    {

        private int horDiag { get; }
        private int verDiag { get; }

        public Rhomb(int centerX, int centerY, int horDiag, int verDiag) : base(centerX, centerY)
        {
            this.horDiag = horDiag;
            this.verDiag = verDiag;
        }
        private Point[] GetCurrPoints()
        {
            return new Point[] {
                new Point(x - (verDiag / 2), y),
                new Point(x, y - (horDiag / 2)),
                new Point(x + (verDiag / 2), y),
                new Point(x, y + (horDiag / 2))};
        }
        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(new Pen(Color.Black), GetCurrPoints());
        }

        public override void HideDrawingBackground()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(new Pen(Form1.ActiveForm.BackColor), GetCurrPoints());
        }

    }
}
