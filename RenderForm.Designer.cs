﻿using System.Drawing;
using System.Windows.Forms;

namespace mandelbrot
{
    partial class RenderForm
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
 

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //
            // PictureBox
            //

            /**
             * this.mandelbrotPB is the PictureBox holding the Bitmap : Image named this.mandelbrotBM
             */
            this.mandelbrotPB = new PictureBox();
            this.mandelbrotPB.Size = new Size(1200, 1200);
            this.mandelbrotPB.Location = new Point(0, 100);
            this.mandelbrotPB.MouseClick += this.mandelbrotPB_Click;

            this.Controls.Add(this.mandelbrotPB);

            this.mandelbrotBM = new Bitmap(this.mandelbrotPB.Width / 2, this.mandelbrotPB.Height / 2);
            this.redrawBitmap();

            /**
             * The listbox
             */
            this.colorLB = new ListBox();
            this.colorLB.Size = new System.Drawing.Size(100, 67);
            this.colorLB.Location = new System.Drawing.Point(550, 20);
            this.Controls.Add(this.colorLB);

            this.colorLB.SelectionMode = SelectionMode.One;

            this.colorLB.Items.Add("Rainbow");
            this.colorLB.Items.Add("Grass");
            this.colorLB.Items.Add("MaxIter");
            this.colorLB.Items.Add("White");
            this.colorLB.SetSelected(0, true);
            this.colorScheme = this.colorLB.GetItemText(this.colorLB.SelectedItem);




            /**
             * Beyond here is partially Visual Studio designer generated.
             * LOOK AT README !
             */

            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = this.centerX.ToString();
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Midden X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Midden Y:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = this.centerY.ToString();
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Schaal:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(352, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = this.scale.ToString();
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max Iteraties:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(400, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 22);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = this.maxIter.ToString();
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zoom:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(720, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(50, 22);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = this.zoomfactor.ToString();
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // RenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 840);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Name = "RenderForm";
            this.Text = "Mandelbrot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
    }
}