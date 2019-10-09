using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    class Ejercicio4
    {

        static long Binario(long num)
        {
            if (num < 2)
            {
                return num;
            }

            else
            {
                return num % 2 + (10 * Binario(num / 2));
            }


        }


        static void Main(string[] args)
        {
            long num;

            Console.WriteLine("Ingrese el numero que desea convertir: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("El numero binario es: " + (Binario(num)));
            Console.ReadKey();

        }

    }
}
