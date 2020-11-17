using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class UserInterface
    {
        /// <summary>
        /// Imprime el Menú Principal
        /// </summary>
        public static void PrintMainMenu()
        {
            Console.WriteLine("----------------");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" MENÚ PRINCIPAL ");
            Console.ResetColor();
            Console.WriteLine("----------------");

            Console.WriteLine("1) Potencia en base 2");
            Console.WriteLine("2) Sumatorio de un número");
            Console.WriteLine("3) Calcular el factorial de un número");
            Console.WriteLine("4) Saber si un número es primo");
            Console.WriteLine("5) Imprimir la serie de Fibonacci");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0) Salir del programa");
            Console.ResetColor();

        }
        /// <summary>
        /// Imprime el Menú Potencia de 2
        /// </summary>
        public static void PrintPower2()
        {
            Console.WriteLine("--------------------");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Potencia en base 2 ");
            Console.ResetColor();
            Console.WriteLine("--------------------");

        }
    }
}
