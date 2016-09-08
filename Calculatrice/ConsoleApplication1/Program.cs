using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice_degrés
{
    class calculatrice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversion F en C V1.0, 12/07/16");
            string saisie1;
            double F;
            double C;

            Console.WriteLine("entrez des degrés Fahrenheit");

            saisie1 = Console.ReadLine();
            F = Convert.ToInt32(saisie1);

            C = (5.0/(double)9)*(F - 32);

            Console.WriteLine("Le résultat en Celsius :" + C);
            Console.ReadLine();

        }
    }
}
