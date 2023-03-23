using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,num2;
            int dis;



            Console.WriteLine("Ingrese el primer numero : ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero : ");
            num2 = int.Parse(Console.ReadLine());

            dis = Math.Abs ( num - num2);

           

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("La cantidad de numeros de distancia es: " + dis);

            
            Console.ReadKey();
        }
    }
}