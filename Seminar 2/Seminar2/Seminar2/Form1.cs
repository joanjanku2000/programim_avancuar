using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            movableLabel.Location = new Point(0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void moveRight_Click(object sender, EventArgs e)
        {

            // if (movableLabel.Location.X < panel1.Right)
                movableLabel.Location = new Point(movableLabel.Location.X + 2,movableLabel.Location.Y);
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
          //  if (movableLabel.Location.X < panel1.Left)
                movableLabel.Location = new Point(movableLabel.Location.X - 2, movableLabel.Location.Y);
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
         //   if (movableLabel.Location.Y < panel1.Top)
                movableLabel.Location = new Point(movableLabel.Location.X , movableLabel.Location.Y - 2);
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            // if (movableLabel.Location.Y > panel1.Bottom)

            movableLabel.Location = new Point(movableLabel.Location.X , movableLabel.Location.Y + 2);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

   

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
