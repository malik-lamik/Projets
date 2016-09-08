using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            int nbre;
            int resultat;
            int i;

            Console.WriteLine("Rentre un nombre !");
            saisie = Console.ReadLine();
            nbre = Convert.ToInt32(saisie);

            i = 0;
            resultat = 0;


            while (i <= nbre)
            {
                resultat = resultat + i;
                i++;


           }
            Console.Write(resultat);
            Console.ReadLine();
        }

    }
}
