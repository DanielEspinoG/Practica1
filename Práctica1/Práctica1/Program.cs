using System;

namespace Práctica1
{
    class Program
    {
        /// <summary>
        /// Imprime el Menú con el título que le damos (MENÚ PRINCIPAL) y un Submenú, consola espera a que el usuario elija una de las opciones 
        /// que aparecen para mostrar ese Menú y en caso de introducir un dato fuera de ese Submenú imprime un aviso al usuario de error.
        /// </summary>
        public static void LunchMainMenu()
        {
            Console.Clear();
            UserInterfaceMenu.PrintHead("           MENÚ PRINCIPAL           ", ConsoleColor.DarkCyan);
            UserInterfaceMenu.PrintSubMainMenu();

            while (true)
            {
                int option = Controllers.ReadOption();

                switch (option)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Clear();
                        Controllers.LaunchPower2Menu();
                        break;
                    case 2:
                        Console.Clear();
                        Controllers.LaunchSumatoriMenu();
                        break;
                    case 3:
                        Console.Clear();
                        Controllers.LaunchFactirialMenu();
                        break;
                    case 4:
                        Console.Clear();
                        Controllers.LaunchPrimeMenu();
                        break;
                    case 5:
                        Console.Clear();
                        Controllers.LaunchFibonacciMenu();
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
