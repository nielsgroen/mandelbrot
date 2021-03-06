﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace mandelbrot
{
    class Mandelbrot
    {
        public Color ColorSet; // niet in gebruik

        public Mandelbrot(Color ColorSet)
        {
            this.ColorSet = ColorSet; // niet in gebruik
        }

        public static Color calcColor(double x, double y, int maxIter, String colorScheme) // returnt kleur van mandelbrotgetal van bijbehorende coordinaten
        {
            int colorInt = Mandelbrot.calcIter(x, y, maxIter);
            Color result;
            
            int[] highIterRGB = new int[] { 255, 0, 0 }; // defining the color set for MaxIter and potentially other Color Sets
            int[] lowIterRGB = new int[] { 0, 255, 0 }; // idem dito
            double a = (double) colorInt / maxIter; // calculate coefficient for convex combination of high and low arrays
            int[] resultRGB = new int[3];

            if(colorScheme == "Rainbow")
            {
                /**
                * The Rainbow
                */
                resultRGB[0] = (int)((Math.Sin((double)colorInt * 0.1) + 1) * 126);
                resultRGB[1] = (int)((Math.Sin((double)(colorInt - 80) * 0.1) + 1) * 126);
                resultRGB[2] = (int)((Math.Sin((double)(colorInt - 160) * 0.1) + 1) * 126);
            }
            else if (colorScheme == "Grass")
            {
                resultRGB[0] = (int)((Math.Sin((double)(colorInt - 80) * 0.01) + 1) * 126);
                resultRGB[1] = (int)((Math.Sin((double)(colorInt) * 0.01) + 1) * 126);
                resultRGB[2] = (int)((Math.Sin((double)(colorInt - 160) * 0.01) + 1) * 126);
            }
            else if (colorScheme == "MaxIter")
            {
                for (int i = 0; i < 3; i++)
                {
                    resultRGB[i] = (int)(a * highIterRGB[i] + (1 - a) * lowIterRGB[i]);
                }
            }
            else if (colorScheme == "White")
            {
                if (colorInt % 2 == 0 && colorInt != maxIter)
                {
                    resultRGB[0] = 255;
                    resultRGB[1] = 255;
                    resultRGB[2] = 255;
                }
            }
            else
            {
                resultRGB[0] = (int)Math.Pow(colorInt % 255, 2) / 500 + 100;
                resultRGB[1] = (int)Math.Pow((colorInt - 128) % 255, 2) / 500 + 100;
                resultRGB[2] = (int)Math.Pow((colorInt - 296) % 255, 2) / 500 + 100;
            }
            

            result = Color.FromArgb(resultRGB[0], resultRGB[1], resultRGB[2]);
            if (colorInt == maxIter)
            {
                result = Color.Black;
            }
            return result;
        }


        public static int calcIter(double x, double y, int maxIter) // returnt het mandelbrotgetal
        {
            double a = 0, b = 0;
            int i;
            for (i = 0; i < maxIter && Math.Sqrt(a * a + b * b) < 2; i++)
            {
                double anew = a * a - b * b + x;
                double bnew = 2 * a * b + y;
                a = anew;
                b = bnew;
            }
            
            return i;
        }


    }
}
