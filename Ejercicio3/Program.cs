using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char estado_civil;

            Console.Write("Ingrese su estado civil: ");
            estado_civil = char.Parse(Console.ReadLine().ToLower());

            switch (estado_civil)
            {
                case 's':
                    Console.WriteLine("Soltero");
                    break;
                case 'c':
                    Console.WriteLine("Casado");
                    break;
                case 'v':
                    Console.WriteLine("Viudo");
                    break;
                case 'd':
                    Console.WriteLine("Divorciado");
                    break;
                default:
                    Console.WriteLine("Sin especificar");
                    break;
            }
        }
    }
}
