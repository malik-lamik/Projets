using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_du_temps
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Conversion du temps V1.0 12/07/16");
            string seconde;
            int a, s, h, m,r,rr;

            Console.WriteLine("entrer les secondes");
            seconde = Console.ReadLine();
            a = Convert.ToInt32(seconde);

            if (a >= 3600) // le a c'est la valeur qu'on va stocker quand on va rentrer nos seconde
            {
                h = a / 3600;
                r = a % 3600;   // r c'est le reste des heures
                m = r / 60;    
                rr = r % 60;    // rr c'est le reste des minutes    
                s = rr;     
                Console.WriteLine("il y a " + h + " heures " + m + " minutes " + s + " secondes");
                Console.ReadLine();
            }
            else if (a >= 60)
            {
                m = a / 60;
                r = a % 60;
                s = r;      // le r c'est le reste des minutes
                Console.WriteLine("il y a " + m + " minutes " + s + " secondes");
                Console.ReadLine();
            }
            else
                s = a;
                Console.WriteLine("il y a " + s + " secondes");
                Console.ReadLine();
        }
    }
}

