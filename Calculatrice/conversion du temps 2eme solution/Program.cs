using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion_du_temps_2eme_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversion du temps V1.0 12/07/16\n"); // le "n" permet de faire un saut de ligne

            string saisie;
            int heure;
            int minute;
            int seconde;

            Console.WriteLine("afficher le nombre de seconde");
            saisie = Console.ReadLine();
            seconde = Convert.ToInt32(saisie);

            heure = seconde / 3600;
            seconde = seconde % 3600;
            minute = seconde / 60;
            seconde = seconde % 60;

            Console.WriteLine("ça corresponds à : " + heure + " heures " + minute + " minutes "  + seconde +  " seconde ");
            Console.ReadLine();

        }

    }
}
