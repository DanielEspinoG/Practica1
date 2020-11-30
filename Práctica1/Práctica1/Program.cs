using System;

namespace Práctica1
{
    class Program
    {
        /// <summary>
        /// Imprime el Menú Principal. Formada por la cabecera del Menú Principal junto 
        /// con 5 opciones de las cuales puedes elegir una de ellas para ir a su menú. 
        /// </summary>
        public static void LunchMainMenu()
        {
            UserInterfaceMenu.PrintHead("MENÚ PRINCIPAL", ConsoleColor.DarkCyan);
            UserInterfaceMenu.PrintSubMainMenu();
            Boolean bucle = true;

            while (bucle)
            {
                int option = Controllers.ReadOption();

                switch (option)
                {
                    case 0:
                        bucle = false;
                        break;
                    case 1:
                        Console.Clear();
                        Controllers.LaunchPower2Menu();
                        UserInterfaceMenu.PrintHead("MENÚ PRINCIPAL", ConsoleColor.DarkCyan);
                        UserInterfaceMenu.PrintSubMainMenu();
                        break;
                    case 2:
                        Console.Clear();
                        Controllers.LaunchSumatoriMenu();
                        UserInterfaceMenu.PrintHead("MENÚ PRINCIPAL", ConsoleColor.DarkCyan);
                        UserInterfaceMenu.PrintSubMainMenu();
                        break;
                    case 3:
                        Console.Clear();
                        Controllers.LaunchFactirialMenu();
                        UserInterfaceMenu.PrintHead("MENÚ PRINCIPAL", ConsoleColor.DarkCyan);
                        UserInterfaceMenu.PrintSubMainMenu();
                        break;
                    case 4:
                        Console.Clear();
                        Controllers.LaunchPrimeMenu();
                        UserInterfaceMenu.PrintHead("MENÚ PRINCIPAL", ConsoleColor.DarkCyan);
                        UserInterfaceMenu.PrintSubMainMenu();
                        break;
                    case 5:
                        Console.Clear();
                        Controllers.LaunchFibonacciMenu();
                        UserInterfaceMenu.PrintHead("MENÚ PRINCIPAL", ConsoleColor.DarkCyan);
                        UserInterfaceMenu.PrintSubMainMenu();
                        break;
                    default:
                        Console.WriteLine("No se ha seleccionado ninguna opción");
                        Console.WriteLine("Inserte un número entre el 0 y el 5");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            LunchMainMenu();
        }
    }
}
