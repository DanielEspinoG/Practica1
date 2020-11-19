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
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------");
            Console.Write("-");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("           MENÚ PRINCIPAL           ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
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
        /// Imprime la cabecera del submenú POTENCIA DE 2
        /// </summary>
        public static void PrintPower2Head()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------");
            Console.Write("-");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("         POTENCIA EN BASE 2         ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
        }

        /// <summary>
        /// Imprime la cabecera del submenú SUMA
        /// </summary>
        public static void PrintAddHead()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------");
            Console.Write("-");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("                SUMA                ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
        }

        /// <summary>
        /// Imprime la cabecera del submenú FACTORIAL DE UN NÚMERO
        /// </summary>
        public static void PrintFactorialHead()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------------------------------");
            Console.Write("-");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("       FACTORIAL DE UN NÚMERO       ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
        }

        /// <summary>
        /// Imprime la cabecera del submenú NÚMERO PRIMO
        /// </summary>
        public static void PrintPrimeHead()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------------------------------");
            Console.Write("-");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("       ¿ESTE NÚMERO ES PRIMO?       ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
        }

        /// <summary>
        /// Imprime la cabecera del submenú FIBONACCI
        /// </summary>
        public static void PrintFibonacciHead()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------------------------------");
            Console.Write("-");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("         SERIE DE FIBONACCI         ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
        }

        public static void PrinSubMenu()
        {
            Console.WriteLine("1) Realizar una nueva operación");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0) Regresar al Menú Principal");
            Console.ResetColor();

            while (true)
            {
                int option = UserInterfaceUtils.ReadOption();

                switch (option)
                {
                    case 0:
                        Console.Clear();
                        Program.LunchMainMenu();
                        break;
                    case 1:
                        Console.Clear();
                        UserInterfaceUtils.LaunchPower2Menu();
                        break;
                    default:
                        Console.WriteLine("No se ha seleccionado ninguna opción");
                        Console.WriteLine("Inserte el número 0 o 1");
                        break;
                }
            }
        }

        public static void PrintAddSubMenu()
        {
            Console.WriteLine("1) Acumular otro número");
            Console.WriteLine("2) Realizar una nueva operación");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0) Regresar al Menú Principal");
            Console.ResetColor();

            while (true)
            {
                int option = UserInterfaceUtils.ReadOption();

                switch (option)
                {
                    case 0:
                        Console.Clear();
                        Program.LunchMainMenu();
                        break;
                    case 1:

                        break;
                    case 2:
                        Console.Clear();
                        UserInterfaceUtils.LaunchAddMenu();
                        break;
                }
            }
        }


        public static void PrinFactorialSubMenu()
        {
            Console.WriteLine("1) Realizar una nueva operación");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0) Regresar al Menú Principal");
            Console.ResetColor();

            while (true)
            {
                int option = UserInterfaceUtils.ReadOption();

                switch (option)
                {
                    case 0:
                        Console.Clear();
                        Program.LunchMainMenu();
                        break;
                    case 1:
                        Console.Clear();
                        UserInterfaceUtils.LaunchFactirialMenu();
                        break;
                    default:
                        Console.WriteLine("No se ha seleccionado ninguna opción");
                        Console.WriteLine("Inserte el número 0 o 1");
                        break;
                }
            }
        }

        public static void PrinPrimeSubMenu()
        {
            Console.WriteLine("1) Realizar una nueva operación");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0) Regresar al Menú Principal");
            Console.ResetColor();

            while (true)
            {
                int option = UserInterfaceUtils.ReadOption();

                switch (option)
                {
                    case 0:
                        Console.Clear();
                        Program.LunchMainMenu();
                        break;
                    case 1:
                        Console.Clear();
                        UserInterfaceUtils.LaunchPrimeMenu();
                        break;
                    default:
                        Console.WriteLine("No se ha seleccionado ninguna opción");
                        Console.WriteLine("Inserte el número 0 o 1");
                        break;
                }
            }
        }
        /*
        public static void PrinFibonacciSubMenu()
        {
            Console.WriteLine("1) Realizar una nueva operación");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0) Regresar al Menú Principal");
            Console.ResetColor();

            while (true)
            {
                int option = UserInterfaceUtils.ReadOption();

                switch (option)
                {
                    case 0:
                        Console.Clear();
                        Program.LunchMainMenu();
                        break;
                    case 1:
                        Console.Clear();
                        UserInterfaceUtils.LaunchFibonacciMenu();
                        break;
                    default:
                        Console.WriteLine("No se ha seleccionado ninguna opción");
                        Console.WriteLine("Inserte el número 0 o 1");
                        break;
                }
            }
        }
        */

    }
}
