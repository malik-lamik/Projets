using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_des_boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            string  saisie;
            int nbre;
            int y;

            Console.WriteLine("Rentre un nombre !");

            

            saisie = Console.ReadLine();
            nbre = Convert.ToInt32(saisie);

            y = nbre ;

            while (nbre != y + 10) 
            {
                nbre = nbre + 1;
                Console.WriteLine("Les nombres sont " + nbre);
                
            }
                Console.ReadLine();
           
        }
    }
}
