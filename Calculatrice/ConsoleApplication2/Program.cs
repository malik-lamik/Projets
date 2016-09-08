using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console V1.0, 16/07/16");

            string saisie;
            decimal a;
            char b;

            Console.WriteLine("saisie un nombre pour connaitre l'unicode");
            saisie = Console.ReadLine();
            a = Convert.ToDecimal(saisie);
            b = (char) a;

            Console.WriteLine("l'unicode est " + b);
            Console.ReadLine();

            

        }
    }
}
