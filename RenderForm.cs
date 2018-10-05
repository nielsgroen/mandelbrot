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
        double scale, centerX, centerY, zoomfactor;
        Bitmap mandelbrotBM;
        PictureBox mandelbrotPB;
        ListBox colorLB;
        String colorScheme;

        public RenderForm()
        {
            // Variabelen worden ingevuld bij initialisatie
            this.maxIter = 300;
            this.scale = 0.01;
            this.centerX = 0;
            this.centerY = 0;
            this.zoomfactor = 2;
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
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object o, EventArgs e) // Wanneer de OK button geklikt wordt
        {
            this.centerX = double.Parse(this.textBox1.Text);
            this.centerY = double.Parse(this.textBox2.Text);
            this.scale = double.Parse(this.textBox3.Text);
            this.maxIter = int.Parse(this.textBox4.Text);
            this.zoomfactor = double.Parse(this.textBox5.Text);
            this.colorScheme = this.colorLB.GetItemText(this.colorLB.SelectedItem);
            this.redrawBitmap();
        }

        private void mandelbrotPB_Click(object o, MouseEventArgs e) // Wanneer er gezoomd wordt
        {
            this.centerX = (e.X - (double)this.mandelbrotBM.Width / 2) * this.scale + this.centerX;
            this.centerY = (e.Y - (double)this.mandelbrotBM.Height / 2) * this.scale + this.centerY;
            this.maxIter = int.Parse(this.textBox4.Text);
            this.zoomfactor = double.Parse(this.textBox5.Text);
            this.scale /= this.zoomfactor;
            this.colorScheme = this.colorLB.GetItemText(this.colorLB.SelectedItem);

            // Na het zoomen worden de waarden in de textboxen geupdate.
            this.textBox1.Text = this.centerX.ToString();
            this.textBox2.Text = this.centerY.ToString();
            this.textBox3.Text = this.scale.ToString();
            this.textBox4.Text = this.maxIter.ToString();

            this.redrawBitmap();
        }

        private void redrawBitmap() // berekent opnieuw de bitmap en update de picturebox om de verandering te laten zien
        {
            Graphics gr = Graphics.FromImage(this.mandelbrotBM);

            // Voor elke pixel worden de wiskundige coordinaten uitgerekend
            // De pixel wordt vervolgens gekleurd naar de juiste kleur

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
