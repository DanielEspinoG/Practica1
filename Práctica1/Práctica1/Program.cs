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
            Boolean bucle = true;

            while (bucle)
            {
                Console.Clear();
                UserInterfaceMenu.PrintHead("MENÚ PRINCIPAL", ConsoleColor.DarkCyan);
                UserInterfaceMenu.PrintSubMainMenu();
                int option = Controllers.ReadOption();

                switch (option)
                {
                    case 0:
                        bucle = false;
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
