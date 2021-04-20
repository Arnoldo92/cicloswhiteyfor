using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicloswhiteyfor
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //For
            //Parte1 valor de la interacion
            //parte2 condicion
            //Parte3 aumento o decremento
            int tabla;
            int i = 1; //parte1

            Console.WriteLine("Ingrese el numero de la tabla que quiere calcular");
            tabla = int.Parse(Console.ReadLine());

            //Parte2 
            while (i <= 10)
            {
                Console.WriteLine("" + tabla * i);
                i++; //Parte3
            }
            Console.ReadKey();
        }
    }
}
