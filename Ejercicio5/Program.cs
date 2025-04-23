using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Cual es el valor de 'n': ");
            n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <=n; i++)
            {
                suma = suma + (i * i);
                Console.WriteLine(i*i);
            }
            Console.WriteLine("La suma es: "+suma);
        }
    }
}
