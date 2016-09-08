using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            int nbre;
            int y;
            int resultat;

            Console.WriteLine("Rentre un nombre !");
            saisie = Console.ReadLine();
            nbre = Convert.ToInt32(saisie);

            y = 0;

            while (y <= 10)
            {
                resultat = y*nbre ;
                y++;
                Console.WriteLine(y+" x " +nbre+ " = " + resultat);

            }
            Console.ReadLine();
        }
    }
}
			 