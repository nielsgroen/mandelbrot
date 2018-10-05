using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mandelbrot
{
    public partial class RenderForm : Form
    {
        int maxIter;
        double scale, centerX, centerY, zoomFactor;
        Bitmap mandelbrotBM;
        PictureBox mandelbrotPB;
        ListBox colorLB;
        String colorScheme;

        public RenderForm()
        {
            this.maxIter = 300;
            this.scale = 0.01;
            this.centerX = 0;
            this.centerY = 0;
            this.zoomFactor = 2;
            this.colorScheme = "Rainbow";
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object o, EventArgs e)
        {
            this.centerX = double.Parse(this.textBox1.Text);
            this.centerY = double.Parse(this.textBox2.Text);
            this.scale = double.Parse(this.textBox3.Text);
            this.maxIter = int.Parse(this.textBox4.Text);
            this.colorScheme = this.colorLB.GetItemText(this.colorLB.SelectedItem);
            this.redrawBitmap();
        }

        private void mandelbrotPB_Click(object o, MouseEventArgs e)
        {
            this.centerX = (e.X - (double)this.mandelbrotBM.Width / 2) * this.scale + this.centerX;
            this.centerY = (e.Y - (double)this.mandelbrotBM.Height / 2) * this.scale + this.centerY;
            this.scale /= this.zoomFactor;
            this.colorScheme = this.colorLB.GetItemText(this.colorLB.SelectedItem);

            this.textBox1.Text = this.centerX.ToString();
            this.textBox2.Text = this.centerY.ToString();
            this.textBox3.Text = this.scale.ToString();
            this.textBox4.Text = this.maxIter.ToString();

            this.redrawBitmap();
        }

        private void redrawBitmap()
        {
            Graphics gr = Graphics.FromImage(this.mandelbrotBM);
            // Mandelbrot mandelbrot = new Mandelbrot( Color.Black );

            for (int i = 0; i < this.mandelbrotBM.Width; i++)
            {
                for (int j = 0; j < this.mandelbrotBM.Height; j++)
                {
                    double x = (i - (double)this.mandelbrotBM.Width / 2) * this.scale + this.centerX;
                    double y = (j - (double)this.mandelbrotBM.Height / 2) * this.scale + this.centerY;
                    this.mandelbrotBM.SetPixel(i, j, Mandelbrot.calcColor(x, y, this.maxIter, this.colorScheme));
                }
            }

            gr.DrawImage(this.mandelbrotBM, 0, 0, this.mandelbrotBM.Width, this.mandelbrotBM.Height);
            mandelbrotPB.Image = this.mandelbrotBM;
        }


        // textbox1 -> center x
        // textbox2 -> center y
        // textbox3 -> scale
        // textbox4 -> max iteraties
    }
}
