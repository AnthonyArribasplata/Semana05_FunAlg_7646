using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            char estado_civil;

            Console.Write("Ingrese su estado civil: ");
            estado_civil = char.Parse(Console.ReadLine());

            if (estado_civil=='s' || estado_civil=='S')
            {
                Console.WriteLine("Soltero");
            } else if (estado_civil=='c' || estado_civil=='C')
            {
                Console.WriteLine("Casado");
            } else if (estado_civil=='v' || estado_civil=='V')
            {
                Console.WriteLine("Viudo");
            }
            else if (estado_civil=='d' || estado_civil=='D')
            {
                Console.WriteLine("Divorciado");
            } else
            {
                Console.WriteLine("Sin especificar");
            }
        }
    }
}
