using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre,i;

            Console.WriteLine("entre un chiffre");
            nombre = Convert.ToInt32(Console.ReadLine());

            i = 0;

            while (i < nombre-1)
            {
                i++;
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
    }
}
