using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            char estado_civil;

            Console.Write("Ingrese su estado civil: ");
            estado_civil = char.Parse(Console.ReadLine());

            if (estado_civil == 's' || estado_civil=='S')
            {
                Console.WriteLine("Soltero");
            }
            else
            {
                //tenemos todas las letras menos la 's'
                if (estado_civil == 'c')
                {
                    Console.WriteLine("Casado");
                }
                else
                {
                    //todas las caracteres menos la 'c' y 's'
                    if (estado_civil=='v')
                    {
                        Console.WriteLine("Viudo");
                    } else
                    {
                        //todas menos 'c' 's' y 'v'
                        if (estado_civil=='d')
                        {
                            Console.WriteLine("Divorciado");
                        } else
                        {
                            //menos 'c' 's' 'v' y 'd'
                            Console.WriteLine("Sin especificar");
                        }
                    }
                }
            }
        }
    }
}
