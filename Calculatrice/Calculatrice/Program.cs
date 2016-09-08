using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class calculatrice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculatrice V1.0, 11/07/16");
            String saisie1;
            String saisie2;
            Double Nbre1;
            Double Nbre2;
            Double Resultat;

            Console.WriteLine("entrez le Nbre1");
            saisie1 = Console.ReadLine();
            Nbre1 = Convert.ToInt32(saisie1);

            Console.WriteLine("entrez le Nbre2");
            saisie2 = Console.ReadLine();
            Nbre2 = Convert.ToInt32(saisie2);

            Resultat = Nbre1 + Nbre2;
            Console.WriteLine("Le résultat est :" + Resultat);
            Console.ReadLine();

        }
    }
}
