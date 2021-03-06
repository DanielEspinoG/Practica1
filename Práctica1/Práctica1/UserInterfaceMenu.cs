﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class UserInterfaceMenu
    {
        /// <summary>
        /// Imprime el submenu del menú principal.
        /// </summary>
        public static void PrintSubMainMenu()
        {
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
        /// Imprime la cabecera de un menú.
        /// </summary>
        /// <param name="Title">Titulo del menú.</param>
        /// <param name="color">Color de la cabecera.</param>
        public static void PrintHead(string Title, ConsoleColor color)
        {
            int countcaracter = Title.Length;
            Console.BackgroundColor = color;

            for (int i = 0; i < countcaracter + 4; i++)
                Console.Write("-");

            Console.WriteLine("");
            Console.ResetColor();
            Console.Write("  ");
            Console.ForegroundColor = color;
            Console.Write(Title);
            Console.ResetColor();
            Console.WriteLine("");
            Console.BackgroundColor = color;

            for (int i = 0; i < countcaracter + 4; i++)
                Console.Write("-");

            Console.WriteLine("");
            Console.ResetColor();
        }
    }
}
