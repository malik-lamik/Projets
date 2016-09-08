using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_participation
{
    class Program
    {
        static void Main(string[] args)
        {
            int celibataire;
            int enfant;
            int salaire;
            int part;
            part = 0;
            salaire = 0;
            Console.WriteLine("Etes vous célibataire ? oui = 1 ou non = 2");
            celibataire = Convert.ToInt16(Console.ReadLine());

            if ((celibataire != 1)&& (celibataire!=2))
            {
                Console.WriteLine("Erreur !");
                Console.ReadLine();
                return;
            }
            if (celibataire == 1)
            {
                part = part + 20;           
            }
            else if (celibataire == 2)
            {
                part = part + 25;
            }

            Console.WriteLine("Entrez le nombre d'enfant");
            enfant = Convert.ToInt32(Console.ReadLine());

            part = part + (enfant * 10);

            Console.WriteLine("Entrez votre salaire");
            salaire = Convert.ToInt32(Console.ReadLine());
            if (salaire < 1200)
            {
                part = part + 10;
            }

            if (part>50)

            {
                part = 50;
            }
            Console.WriteLine("la participation est de " +part);
            Console.ReadLine();
        }
        
    }
}
