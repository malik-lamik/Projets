using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_sommes_des_entiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, nombre2, resultat;

            Console.WriteLine("entre un chiffre");
            nombre = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("entre un 2eme chiffre");
            nombre2 = Convert.ToInt32(Console.ReadLine());

            resultat = 0;

            for (nombre = 0; nombre <= nombre2; nombre++)
            {
                resultat = resultat + nombre;
            }
 
            Console.WriteLine("la somme des entiers est : "+resultat);
            Console.ReadLine();
        }
    }
}
