using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP13
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double reves;
            double num2;
           



            Console.WriteLine("Ingrese el numero que dese ivertir");
            num = int.Parse(Console.ReadLine());

            num2 = num;

            reves = Math.IEEERemainder(num, num2);
            

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("El reves del numero es: " + reves);
            


            Console.ReadKey();
        }
    }
}

