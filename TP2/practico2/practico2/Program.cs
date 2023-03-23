using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    class Program
    {
        static void Main(string[] args)
        {
            float n;
            float dolar = 200;
            float euro = 400;

            Console.WriteLine("Ingrese la cantidad de pesos");
            n = float.Parse(Console.ReadLine());
         
            Console.WriteLine("Su cantidad de pesos en euros es: " + n/euro);
            Console.WriteLine("Su cantidad de pesos en dolares es: " + n / dolar);
            Console.ReadKey();
        }
    }
}