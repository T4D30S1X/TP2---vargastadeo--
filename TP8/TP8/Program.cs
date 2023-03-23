using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Program
    {
        static void Main(string[] args)
        {
            int far;
            Double celcios;

            Console.WriteLine("Ingrese sus grados Fahrenheit: ");
            far = int.Parse(Console.ReadLine());
            celcios = (far - 32) / 1.8;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Sus grados Celcios son: " + celcios);

            Console.ReadKey();

        }
    }
}
