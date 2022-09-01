using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace RuntimeButtonCreation
{
    public partial class Form1 : Form
    {
        Button lastCreatedButton;
        bool isPressed = false;
        int startX, startY;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                lastCreatedButton.Size = new Size(e.X - startX, e.Y - startY);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isPressed)
            {
                lastCreatedButton = new Button();
                startX = e.X;
                startY = e.Y;
                isPressed = true;
                lastCreatedButton.Location = new Point(startX, startY);
                Controls.Add(lastCreatedButton);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }
    }
}
