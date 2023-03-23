using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP13
{
    /* Dado un número de dos cifras, diseñe un programa que permita obtener el número invertido. Ejemplo,
si se introduce 23 que muestre 32. */
    class Program
    {
        static void Main(string[] args)
        {
           int num;
            int reves;
            int num2;
            int num3;




            Console.WriteLine("Ingrese el numero que dese ivertir:");
            num = int.Parse(Console.ReadLine());

            num2 = num / 10;
            num3 = (int)Math.IEEERemainder(num, 10);
            

            reves = num3*10+num2;

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("El reves del numero es: " + reves);



            Console.ReadKey();
        }
    }
}
