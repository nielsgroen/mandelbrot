using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

/**
 * Als eerste een opmerking: De User Interface is in het Nederlands, maar de meeste code (behalve soms voor de UI) is in het Engels geschreven.
 * !!! Tweede opmerking: Voor het maken van de GUI was eerst de Visual Studio designer gebruikt. Maar daarna is er vanaf gestapt.
 * 
 *                      !!! Er kan dus NIET van uit gegaan worden dat de Visual Studio designer goed werkt, het kan zelfs de code corrumperen !!!
 * 
 * 
 * Inhoud:
 *  - Mandelbrot.cs:
 *      * Statische functies om mandelbrotwaarden (en kleur te berekenen)
 *      
 *  - RenderForm.Designer.cs:
 *      * Hier staat de code voor de layout van de RenderForm
 *      * (De bitmap wordt hier ook aangemaakt)
 *      
 *  - RenderForm.cs:
 *      * Hier staan de event listeners van het programma
 * 
 */



namespace mandelbrot
{
    class Program
    {
        public static void Main()
        {
            Form render = new RenderForm();
            Application.Run(render);
        }

    }
}