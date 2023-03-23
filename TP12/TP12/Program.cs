using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double raiz;
            double raiz2;



            Console.WriteLine("Ingrese el numero : ");
            num = int.Parse(Console.ReadLine());


            raiz = Math.Sqrt(num);

            raiz2 = Math.Pow(num, 0.333333333333);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("La raiz cuadrada del numero es : " + raiz);
            Console.WriteLine("La raiz cubica del numero es: " + raiz2);


            Console.ReadKey();
        }
    }
}
