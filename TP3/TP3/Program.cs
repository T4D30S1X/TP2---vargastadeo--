using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            float sb;
           

            Console.WriteLine("Ingrese su salario bruto: ");
            salario = float.Parse(Console.ReadLine());
            sb = (salario * 20) / 100;

            Console.WriteLine("Su salario real es: " + (salario-sb) );
           
            Console.ReadKey();
        }
    }
}
