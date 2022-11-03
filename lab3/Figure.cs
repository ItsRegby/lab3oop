using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Figure
    {
        protected int x { get; set; }
        protected int y { get; set; }

        public Figure(int centerX, int centerY)
        {
            this.x = centerX;
            this.y = centerY;
        }

        public abstract void DrawBlack();
        public abstract void HideDrawingBackground();

        public void MoveRight(int distance, int speed) 
        {
            for (int i = 0; i<Form1.ActiveForm.Width-distance-x; i++) 
            {
                DrawBlack();
                System.Threading.Thread.Sleep(100);
                HideDrawingBackground();
                x += speed;
            }
        }
    }
}
