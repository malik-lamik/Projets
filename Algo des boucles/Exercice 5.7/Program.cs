using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            int nbre;
            int resultat;
            int i;
            int max;
            int position;

            max = 0;
            nbre = 0;
            i = 1;

            

            while (i <= 20)
            {
                
                Console.Write("Rentre un nombre numero " + i + ":" );
                saisie = Console.ReadLine();
                nbre = Convert.ToInt32(saisie);
                i++;

                if (nbre > max )
                {
                    max = nbre ;
                }
                else if (max > i)
                {
                    max = i;
                }
                Console.WriteLine("Le nombre le plus grand est : " + nbre + " et sa position est :" + i);
            }
            
            Console.ReadLine();

        }
    }
}
