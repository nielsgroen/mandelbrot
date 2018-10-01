using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace mandelbrot
{
    class Mandelbrot
    {
        public Color ColorSet;

        public Mandelbrot(Color ColorSet)
        {
            this.ColorSet = ColorSet;
        }

        public Color calcColor(double x, double y, int maxIter)
        {
            int colorInt = Mandelbrot.calcIter(x, y, maxIter);
            Color result = Color.Black;
            if (colorInt % 2 == 0)
            {
                result = Color.Orange;
            }
            return result;
        }


        public static int calcIter(double x, double y, int maxIter)
        {
            double a = 0, b = 0;
            int i;
            for (i = 0; i < maxIter || Math.Sqrt(a * a + b * b) > 2; i++)
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
