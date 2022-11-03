using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            string[] c = textSquare.Text.Split(' ');
            Square sq = new Square(int.Parse(c[0]), int.Parse(c[1]), int.Parse(c[2]));
            sq.MoveRight(int.Parse(c[2]),trackBar1.Value);
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            string[] c = textCircle.Text.Split(' ');
            Circle circ = new Circle(int.Parse(c[0]), int.Parse(c[1]), int.Parse(c[2]));
            circ.MoveRight(int.Parse(c[2]), trackBar1.Value);
        }

        private void Rhomb_Click(object sender, EventArgs e)
        {
            string[] c = textRhomb.Text.Split(' ');
            Rhomb romb = new Rhomb(int.Parse(c[0]), int.Parse(c[1]), int.Parse(c[2]), int.Parse(c[3]));
            romb.MoveRight(int.Parse(c[2]), trackBar1.Value);
        }
    }
}
