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
            int bas;
            int altura;
            int area;
            int perimetro;

            Console.WriteLine("Ingrese la base de un Hexagono: ");
            bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura de un Hexagono: ");
            altura = int.Parse(Console.ReadLine());

            area = bas * altura;
            perimetro = 2 * altura + 2 * bas;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("La area del Hexagono es : " + area);
            Console.WriteLine("El perimetro del Hexagono es: " + perimetro);
            Console.ReadKey();

        }
    }
}