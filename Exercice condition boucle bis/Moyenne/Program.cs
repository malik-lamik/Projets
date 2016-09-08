using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, resultat, compteur,somme;

            Console.WriteLine("entre un chiffre");
            nombre = Convert.ToInt32(Console.ReadLine());

            compteur = 0;
            resultat = 0;
            somme = 0;

            while (nombre != 0)
            {
                Console.WriteLine("entre un chiffre");
                nombre = Convert.ToInt32(Console.ReadLine());

                somme = somme + nombre;
               
                compteur++;
                resultat = somme / compteur;
            }
            Console.WriteLine(somme);
            Console.WriteLine(compteur);
            Console.WriteLine(resultat);
            Console.ReadLine();
        }
    }
}
