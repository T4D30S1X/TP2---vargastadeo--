using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado;
            int da;
            int db;
            int area;
            int perimetro;

            Console.WriteLine("Ingrese la diagonal a de un Rombo: ");
            da = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado de un Rombo: ");
            lado = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la diagonal b de un Rombo: ");
            db = int.Parse(Console.ReadLine());

            area = (da * db) / 2;
            perimetro = lado + lado + lado + lado;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("La area del Rombo es : " + area);
            Console.WriteLine("El perimetro del Rombo es: " + perimetro);
            Console.ReadKey();

        }
    }
}
