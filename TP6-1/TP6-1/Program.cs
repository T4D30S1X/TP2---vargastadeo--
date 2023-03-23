using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            int apotema;
            int area;
            int perimetro;
            int lados;

            Console.WriteLine("Ingrese la Apotema del Hexagono: ");
            apotema = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los lados del Hexagono: ");
            lados = int.Parse(Console.ReadLine());

            perimetro = lados * 6;
            area = (apotema * perimetro) / 2;


            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("La area del Hexagono es : " + area);
            Console.WriteLine("El perimetro del Hexagono es: " + perimetro);
            Console.ReadKey();

        }
    }
}
