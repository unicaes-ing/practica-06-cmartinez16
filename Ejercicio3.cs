using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    class Ejercicio3
    {
        public static double Potencia ( double n1, double n2)
        {
            if (n2 == 1 || n2 == 0)
            {
                return 1;
            }
            else
            {
                double pt = Math.Pow(n1, n2);
                return pt;

            }
        }
        static void Main(string[] args)
        {
            double numBase;
            double exponente;
            Console.WriteLine("Ingrese el numero base");
            numBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente del numero");
            exponente = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" {0} elevado a {1} es : {2}", numBase, exponente, Potencia(numBase, exponente));
            Console.ReadKey();
        }
    }
}