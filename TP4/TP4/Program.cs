using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            int seg;
            float min;
            int h;

            Console.WriteLine("Ingrese una cantidad de segundos: ");
            seg = int.Parse(Console.ReadLine());
            min = seg / 60;
            h = min / 1400;

            Console.WriteLine("La cantidad de minutos es: " + min + " la cantidad de las horas son: " + h);
            Console.ReadKey();

        }
    }
}
