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

namespace ML1
{
    public partial class Form1 : Form
    {
        Point Ant;
        Pen pen;
        Icon icon1 = new Icon("Point1.jpg");
        Icon icon0 = new Icon("Point0.jpg");

        int X = 50; int Y = 50;
        int Dir = 270;

        public Form1()
        {

            Bitmap mapF = new Bitmap(100, 100);
            pictureBox1.Image = mapF;
            pen = new Pen(Color.Black);
            InitializeComponent();
        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false) { timer1.Enabled = true; StartStop.Text = "Стоп"; }
            else { timer1.Enabled = false; StartStop.Text = "Старт"; }
        }

        private void SetPoint_Click(object sender, EventArgs e)
        {
            int x = 0; int y = 0;
            int result = 1;
            if (int.TryParse(PointX.Text, out result)) { x = Int32.Parse(PointX.Text); }
            if (int.TryParse(PointY.Text, out result)) { y = Int32.Parse(PointY.Text); }
            if ((x<=100) || (y <= 100))
            {
                if (mapF.GetPixel(x, y) == Color.White)
                {
                    mapF.SetPixel(x, y, Color.Black);
                }
                else
                {
                    mapF.SetPixel(x, y, Color.White);
                }
                // bmp.Save("map.png");
            }
            else
            {
                MessageBox.Show("Точка выходит за границы поля");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.DrawIcon(icon1, X, Y);

            if (g(X, Y) == Color.White)
            {
                Dir += 90; if (Dir > 360) { Dir = 90; }
            }
            else
            {
                Dir -= 90; if (Dir < 0) { Dir = 270; }
            }

            switch (Dir)
            {
                case 0:
                    if (mapF.GetPixel(X, Y) == Color.White)
                    {
                        mapF.SetPixel(X, Y, Color.Black);
                    }
                    else
                    {
                        mapF.SetPixel(X, Y, Color.White);
                    }
                    X -= 1;
                    break;
                case 90:
                    if (mapF.GetPixel(X, Y) == Color.White)
                    {
                        mapF.SetPixel(X, Y, Color.Black);
                    }
                    else
                    {
                        mapF.SetPixel(X, Y, Color.White);
                    }
                    Y += 1;
                    break;
                case 180:
                    if (mapF.GetPixel(X, Y) == Color.White)
                    {
                        mapF.SetPixel(X, Y, Color.Black);
                    }
                    else
                    {
                        mapF.SetPixel(X, Y, Color.White);
                    }
                    X += 1;
                    break;
                case 270:
                    if (mapF.GetPixel(X, Y) == Color.White)
                    {
                        mapF.SetPixel(X, Y, Color.Black);
                    }
                    else
                    {
                        mapF.SetPixel(X, Y, Color.White);
                    }
                    Y -= 1;
                    break;
                case 360:
                    if (mapF.GetPixel(X, Y) == Color.White)
                    {
                        mapF.SetPixel(X, Y, Color.Black);
                    }
                    else
                    {
                        mapF.SetPixel(X, Y, Color.White);
                    }
                    X -= 1;
                    break;
            }

            Console.WriteLine(X); Console.WriteLine(Y);
            // mapF.Save("map.png");

            pictureBox1.Image = mapF;
        }
    }
}
