using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            int nbre;
            int i;
            int y;
            int e;
            int resultat;
            
            Console.WriteLine("Rentre un nombre !");
            saisie = Console.ReadLine();
            nbre = Convert.ToInt32(saisie);
            i = 1;
            e = 0;
            y = nbre;
            resultat = 0;
            while (i < nbre)
            {
                y = y - 1;
                    i++;
                e = e + y;
                resultat = e + nbre;
            }
            Console.WriteLine(resultat);
            Console.ReadLine();
        }
    }
}
