using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9
{
    class Program
    {
        static void Main(string[] args)
        {
            int bas;
            int comi;
            int ventas;
            int sueldo;


            Console.WriteLine("Ingrese su sueldo base: ");
            bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las 3 ventas realizadas del mes");
            ventas = int.Parse(Console.ReadLine());

            comi = (ventas * 10) / 100;
            sueldo = bas + comi;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Su sueldo total es: "+sueldo);


            Console.ReadKey();
        }
    }
}
