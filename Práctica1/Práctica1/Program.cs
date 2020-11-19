using System;

namespace Práctica1
{
    class Program
    {
        public static void LunchMainMenu()
        {
            UserInterface.PrintMainMenu();

            while (true)
            {
                int option = UserInterfaceUtils.ReadOption();

                switch (option)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Clear();
                        UserInterfaceUtils.LaunchPower2Menu();
                        break;
                    case 2:
                        Console.Clear();
                        UserInterfaceUtils.LaunchAddMenu();
                        break;
                    case 3:
                        Console.Clear();
                        UserInterfaceUtils.LaunchFactirialMenu();
                        break;
                    case 4:
                        Console.Clear();
                        UserInterfaceUtils.LaunchPrimeMenu();
                        break;
                        /*
                    case 5:
                        Console.Clear();
                        UserInterfaceUtils.LaunchFibonacciMenu();
                        break;
                        */
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
