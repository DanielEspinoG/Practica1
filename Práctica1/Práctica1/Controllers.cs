using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class Controllers
    {
        /// <summary>
        /// Imprime el Menú Serie Fibonacci que imprime los 90 primeros números de la serie.
        /// </summary>
        public static void LaunchFibonacciMenu()
        {
            UserInterfaceMenu.PrintHead("SERIE DE FIBONACCI", ConsoleColor.Magenta);
            Console.WriteLine("Muestra los 90 primeros digitos de la Serie de Fibonacci.");
            Console.WriteLine("");
            Utils.GetFibonacci(90);
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
        }

        /// <summary>
        /// Imprime el Menú Número Primo. En el cual imprime si el número introducido, por el usuario, es primo o no.
        /// Si el número introducido no es mayor de 0 muestra un mensaje de error.
        /// </summary>
        public static void LaunchPrimeMenu ()
        {
            UserInterfaceMenu.PrintHead("¿ES UN NÚMERO PRIMO?", ConsoleColor.Cyan);
            Console.WriteLine("Muestra si el valor introducido es Primo o no.");
            Console.WriteLine("");
            while (true)
            {
                int number = ReadInteger("Introduce un valor: ");

                if (0 < number)
                {
                    bool result = Utils.IsPrime(number);

                    if (result == true)
                        Console.WriteLine("El" + number + "SI es Primo");
                    else
                        Console.WriteLine("El " + number + " NO es Primo");
                    break;
                }
                else
                {
                    Console.WriteLine("Error. El valor tiene que ser mayor que 0");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
        }

        /// <summary>
        /// Imprime el Menú Factorial de un número. En el cual imprime el factorial del número introducido por el usuario.
        /// Si el número introducido no es mayor de 0 muestra un mensaje de error.
        /// </summary>
        public static void LaunchFactirialMenu()
        {
            UserInterfaceMenu.PrintHead("FACTORIAL DE UN NÚMERO", ConsoleColor.Yellow);
            Console.WriteLine("Muestra el resultado de la multiplicación de todos los números enteros positivos que hay entre el 1 y el valor dado.");
            Console.WriteLine("");

            while (true)
            {
                int number = ReadInteger("Introduce un valor: ");

                if (0 < number)
                {
                    int result = Utils.GetFactorial(number);
                    Console.WriteLine("Resultado de " + result);
                    break;
                }
                else
                {
                    Console.WriteLine("Error. El valor tiene que ser mayor que 0");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
        }

        /// <summary>
        /// Imprime el Menú Sumatorio. En el cual imprime el sumatorio del número introducido por el usuario.
        /// Si el número introducido no es mayor de 0 muestra un mensaje de error.
        /// </summary>
        public static void LaunchSumatoriMenu()
        {
            UserInterfaceMenu.PrintHead("SUMATORIO", ConsoleColor.Blue);
            Console.WriteLine("Muestra el resultado de la suma desde el número 1 hasta el propio valor introducido.");
            Console.WriteLine("");

            while (true)
            {
                int number = ReadInteger("Introduce un valor: ");

                if (0 < number)
                {
                    int result = Utils.GetSumatori(number);
                    Console.WriteLine("Resultado de " + result);
                    break;
                }
                else
                {
                    Console.WriteLine("Error. El valor tiene que ser mayor que 0");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
        }

        /// <summary>
        /// Imprime el Menú Potencia de 2. En el cual imprime el resultado de 2 elevado al número introducido por el usuario.
        /// </summary>
        public static void LaunchPower2Menu()
        {
            UserInterfaceMenu.PrintHead("POTENCIA EN BASE 2", ConsoleColor.Red);
            Console.WriteLine("Muestra el resultado de multiplicar la base 2 por si mismo varias veces (exponente).");
            Console.WriteLine("");
            int Exponent = ReadInteger("Introduce el exponente: ");
            double result = Utils.GetPower(Exponent, 2);
            Console.WriteLine(String.Format("Resultado: " + result));
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
        }

        /// <summary>
        /// Lee el string introducido por el usuario y lo convierte a int. En el caso de no poder convertirlo muestra un mensaje de error.
        /// </summary>
        /// <param name="message">Valor introducido por el usuario</param>
        /// <returns>Valor introducido por el usuario siempre que sea int</returns>
        public static int ReadInteger(string message)
        {
            while (true)
            {
                try
                {
                    Console.Write(message);
                    string line = Console.ReadLine();
                    int number = Convert.ToInt32(line);
                    return number;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Error. Introduzca un número");
                    Console.WriteLine("");
                }
            }
        }

        /// <summary>
        /// Lee el string introducido por el usuario y lo convierte a int, para elegir una de las opciones del submenú.
        /// </summary>
        /// <returns>
        /// Valor introducido por el usuario o un -1.
        /// </returns>
        public static int ReadOption()
        {
            try
            {
                string option = Console.ReadLine();
                int result = Convert.ToInt32(option);
                return result;
            }
            catch (System.Exception e)
            {
                return -1;
            }
        }
    }
}
