using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10
{
    class Program
    {
        static void Main(string[] args)
        {
            int com;
            int descuento;
            


            Console.WriteLine("Ingrese el total de su compra: ");
            com = int.Parse(Console.ReadLine());
            

            descuento = (com * 15) / 100;

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("El total de pagar es: "+(com-descuento));


            Console.ReadKey();
        }
    }
}