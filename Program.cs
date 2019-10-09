using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    class Program
    {
        static string Tablas (int numero)
        {
            string Tabla = "";
            int n1 = 0;
            int n2 = numero;
            int resultado = 0;
            for (int i = 1; i <= 10; i++)
            {
                n1 = n1 + 1;
                resultado = n1 * n2;
                Console.WriteLine("{0} * {1} = {2}", n2 , n1, resultado);
            }
            return Tabla;
        }
        static string Tablas (int numero, int color)
        {
            string Tabla = "";
            int n1 = 0;
            int n2 = numero;
            int resultado = 0;
            switch ( color )
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }

            for (int i = 1; i <= 10; i++)
            {
                n1 = n1 + 1;
                resultado = n1 * n2;
                Console.WriteLine(" {0} * {1} = {2}", n1, n2, resultado); 
            }
            return Tabla;
        }

        static void Main (string [] args)
        {
            int numero;
            int color;
            Console.WriteLine("Ingrese el numero de la tabla a generar");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el color de la tabla a generar");
            Console.WriteLine(" [1] Azul");
            Console.WriteLine(" [2] Amarillo");
            Console.WriteLine(" [3] Verde" );
            Console.WriteLine(" [4] Magenta");
            color = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(Tablas(numero, color));
            Console.ReadKey();
        }
    }
}