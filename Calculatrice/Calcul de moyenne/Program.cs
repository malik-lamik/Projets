using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul_de_moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moyenne eleve V1.0, 12/07/16");

            string note1;
            string note2;
            string note3;
            
                      
            double coeff3;
            double coeff2;
            double coeff1;
            double resultat;

            Console.WriteLine("entrer la 1ere note");
            note1 = Console.ReadLine();
            coeff3 = Convert.ToInt32(note1)*3;

            Console.WriteLine("entrer la 2eme note");
            note2 = Console.ReadLine();
            coeff2 = Convert.ToInt32(note2)*2;

            Console.WriteLine("entrer la 3eme note");
            note3 = Console.ReadLine();
            coeff1 = Convert.ToInt32(note3);

            resultat = (double)(coeff3 + coeff2 + coeff1) / 6;

            Console.WriteLine("Le résultat est " + resultat);
            Console.ReadLine();
        }

    }
}
