using System;
using System.Collections.Generic;
using System.Text;

namespace TPCSharp
{
    class Cercle
    {
        static void Main()
        {
            //Declaration de variables.
            string saisie; // variable recevant la saisie
            double rayon; // rayon
            double perimetre; // périmètre
            double surface;

            // Etape 1 : lecture du rayon
            Console.WriteLine("V1.0, 11/07/16");
            Console.WriteLine("Entrez la valeur du rayon : ");
            saisie = Console.ReadLine();

            // Etape 2 : calcul et affichage du périmètre
            rayon = Convert.ToDouble(saisie);

            //Calcul du perimetre
            perimetre = 2 * Math.PI * rayon;
            surface = Math.PI * (rayon * rayon);
            Console.Write("Le cercle de rayon " + rayon);
            Console.WriteLine();
            Console.Write("a pour périmetre : " + perimetre);
            Console.WriteLine();
            Console.Write("a pour surface:" + surface);
            Console.WriteLine();

            // Permet de conserver l'affichage de la console
            Console.ReadLine();
        }
    }
}