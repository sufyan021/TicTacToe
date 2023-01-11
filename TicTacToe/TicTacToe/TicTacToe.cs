using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private Boolean P1;

        private Boolean P2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            System.Drawing.Graphics MyGraphics;

            MyGraphics = CreateGraphics();

            Pen Colour = new Pen(System.Drawing.Color.Black);

            MyGraphics.DrawLine(Colour, 250, 65, 250, 265);

            MyGraphics.DrawLine(Colour, 350, 65, 350, 265);

            MyGraphics.DrawLine(Colour, 185, 125, 415, 125);

            MyGraphics.DrawLine(Colour, 185, 200, 415, 200);

        }

        public void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = null;

            pictureBox2.Image = null;

            pictureBox3.Image = null;

            pictureBox4.Image = null;

            pictureBox5.Image = null;

            pictureBox6.Image = null;

            pictureBox7.Image = null;

            pictureBox8.Image = null;

            pictureBox9.Image = null;

            button1.Text = "Restart";

            P1 = true;

            P2 = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image is null)

            {

                if (P1 == true)

                {

                    pictureBox1.Image = global::TicTacToe.Properties.Resources.X;

                    P1 = false;

                    P2 = true;

                }

                else if (P2 == true)

                {

                    pictureBox1.Image = global::TicTacToe.Properties.Resources.O;

                    P2 = false;

                    P1 = true;

                }

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (pictureBox2.Image is null)

            {

                if (P1 == true)

                {

                    pictureBox2.Image = global::TicTacToe.Properties.Resources.X;

                    P1 = false;

                    P2 = true;

                }

                else if (P2 == true)

                {

                    pictureBox2.Image = global::TicTacToe.Properties.Resources.O;

                    P2 = false;

                    P1 = true;

                }

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (pictureBox3.Image is null)

            {

                if (P1 == true)

                {

                    pictureBox3.Image = global::TicTacToe.Properties.Resources.X;

                    P1 = false;

                    P2 = true;

                }

                else if (P2 == true)

                {

                    pictureBox3.Image = global::TicTacToe.Properties.Resources.O;

                    P2 = false;

                    P1 = true;

                }

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (pictureBox4.Image is null)

            {

                if (P1 == true)

                {

                    pictureBox4.Image = global::TicTacToe.Properties.Resources.X;

                    P1 = false;

                    P2 = true;

                }

                else if (P2 == true)

                {

                    pictureBox4.Image = global::TicTacToe.Properties.Resources.O;

                    P2 = false;

                    P1 = true;

                }

            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            if (pictureBox8.Image is null)

            {

                if (P1 == true)

                {

                    pictureBox8.Image = global::TicTacToe.Properties.Resources.X;

                    P1 = false;

                    P2 = true;

                }

                else if (P2 == true)

                {

                    pictureBox8.Image = global::TicTacToe.Properties.Resources.O;

                    P2 = false;

                    P1 = true;

                }

            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            if (pictureBox6.Image is null)

            {

                if (P1 == true)

                {

                    pictureBox6.Image = global::TicTacToe.Properties.Resources.X;

                    P1 = false;

                    P2 = true;

                }

                else if (P2 == true)

                {

                    pictureBox6.Image = global::TicTacToe.Properties.Resources.O;

                    P2 = false;

                    P1 = true;

                }

            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (pictureBox5.Image is null)

            {

                if (P1 == true)

                {

                    pictureBox5.Image = global::TicTacToe.Properties.Resources.X;

                    P1 = false;

                    P2 = true;

                }

                else if (P2 == true)

                {

                    pictureBox5.Image = global::TicTacToe.Properties.Resources.O;

                    P2 = false;

                    P1 = true;

                }

            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            if (pictureBox9.Image is null)

            {

                if (P1 == true)

                {

                    pictureBox9.Image = global::TicTacToe.Properties.Resources.X;

                    P1 = false;

                    P2 = true;

                }

                else if (P2 == true)

                {

                    pictureBox9.Image = global::TicTacToe.Properties.Resources.O;

                    P2 = false;

                    P1 = true;

                }

            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (pictureBox7.Image is null)

            {

                if (P1 == true)

                {

                    pictureBox7.Image = global::TicTacToe.Properties.Resources.X;

                    P1 = false;

                    P2 = true;

                }

                else if (P2 == true)

                {

                    pictureBox7.Image = global::TicTacToe.Properties.Resources.O;

                    P2 = false;

                    P1 = true;

                }

            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
