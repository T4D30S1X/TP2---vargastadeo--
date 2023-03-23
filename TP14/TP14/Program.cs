using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP14
{
    /* Un ciclista parte de una ciudad A a las HH horas, MM minutos y SS segundos. El tiempo de viaje hasta
llegar a otra ciudad B es de T segundos. Escribir un algoritmo que determine la hora de llegada a la ciudad B. */
    internal class Program
    {
        static void Main(string[] args)
        {
            int seg;
            int min;
            int hor;
            int viaj;
            int segT;
            int segR;

            Console.WriteLine("Introduce la Hora de salida de la ciudad A");
            hor=int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce los minutos de salida de la ciudad A");
            min=int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce los segundos de salida de la ciudad A");
            seg=int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la duracion del viaje hacia la ciudad B en segundos");
            viaj=int.Parse(Console.ReadLine());

            segT= hor * 3600 + min * 60 + seg + viaj;
            hor = segT / 3600;
            segR= (int)Math.IEEERemainder(segT ,3600);
            min = segR / 60;
            seg = (int)Math.IEEERemainder(segR, 60);
          
            hor=Math.Abs(hor);
            min = Math.Abs(min);
            seg = (int)Math.Abs(seg);
            
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("La hora de llegada a la ciudad B es de " + hor + ":" + min + ":" + seg);

            Console.ReadKey();
        }
    }
}
