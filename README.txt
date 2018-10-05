
/**
 * Git Repository: https://github.com/nielsgroen/mandelbrot/
 * Gemaakt door (Contributors): Gianno Cardose (student id: 6388345), Niels Groeneveld (student id: 6646255)
 *
 *
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
 *      * Hier wordt ook het grootste gedeelte van de logica uitgevoerd (m.b.v. Mandelbrot.cs)
 *      
 *   textbox1 -> center x
 *   textbox2 -> center y
 *   textbox3 -> scale
 *   textbox4 -> max iteraties
 * 
 * 
 * 
 * Functionaliteit:
 *  - Alle waarden kunnen bovenin worden veranderd.
 *  - Deze kunnen bevestigd worden met de OK button
 *  
 *  - Door op de afbeelding te klikken worden de huidige waarden ook bevestigd
 *  - Tevens wordt ook gezoomd met de door de gebruiker aangegeven zoomfactor
 *  
 *  - Voorbeeld: Na het selecteren van een ander kleurenschema, kan deze worden bevestigd door OK te klikken of te zoomen.
 * 
 */
