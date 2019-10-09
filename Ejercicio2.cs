using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    class Ejercicio2
    {
        public static string Dibujos(decimal forma)
        {
            string ah = "";
            for (int i = 1; i <= forma; i++)
            {
                ah = ah + "*";
            }
            return ah;
        }

        public static string Dibujos(decimal forma, string forma2)
        {
            string ah = forma2;
            for (int i = 1; i <= forma; i++)
            {
                ah = ah + forma2;
            }
            return ah;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el ancho de la figura: ");
            decimal anch = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Escriba el alto de la figura: ");
            decimal alt = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la forma que desea: ");
            string form = Console.ReadLine();
            Console.WriteLine("Escriba las coordenadas donde mostrar su figura o escriba 0 para las determinadas");
            Console.WriteLine("Coordenada X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coordenada Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                if (form == "")
                {
                    Console.WriteLine("---------DIBUJO---------");
                    for (int lin = 1; lin <= alt; lin++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(Dibujos(anch));
                    }

                    Console.ReadKey();
                }
            }
            if (x > 0 && y > 0)
            {
                if (form == "")
                {
                    Console.WriteLine("--------DIBUJO--------");
                    for ( int lin = 1; lin <= alt; lin ++ )
                    {
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Dibujos(anch));

                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("--------DIBUJO--------");
                    for ( int lin = 1; lin <= alt; lin ++)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(Dibujos(anch, form));
                    }
                    Console.ReadKey();
                }
            }
        }
    }
    }
