﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class Controllers
    {
        /// <summary>
        /// Imprime el Menú con el título que le damos (SERIE DE FIBONACCI), imprime el resultado de la operación que realiza
        /// la función que llamamos (GetFibonacci) y espera a que el Usuario pulse una tecla para volver al Menú principal.
        /// </summary>
        public static void LaunchFibonacciMenu()
        {
            UserInterfaceMenu.PrintHead("         SERIE DE FIBONACCI         ", ConsoleColor.Magenta);
            Console.WriteLine("Muestra los 90 primeros digitos de la Serie de Fibonacci.");
            Console.WriteLine("");
            Utils.GetFibonacci(90);
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
            Program.LunchMainMenu();
        }

        /// <summary>
        /// Imprime el Menú con el título que le damos (¿ES UN NÚMERO PRIMO?), consola espera a que el usuario introduzca un dato, imprime el resultado de la 
        /// operación que realiza la función que llamamos (GetPrime) con el dato introducido y espera a que el Usuario pulse una tecla para volver al Menú principal.
        /// </summary>
        public static void LaunchPrimeMenu ()
        {
            UserInterfaceMenu.PrintHead("        ¿ES UN NÚMERO PRIMO?        ", ConsoleColor.Cyan);
            Console.WriteLine("Muestra si el valor introducido es Primo o no.");
            Console.WriteLine("");
            int number = ReadInteger("Introduce un valor: ");
            bool result = Utils.IsPrime(number);
            if (result == true)
                Console.WriteLine("El " + number + " SI es Primo");
            else
                Console.WriteLine("El " + number + " NO es Primo");
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
            Program.LunchMainMenu();
        }

        /// <summary>
        /// Imprime el Menú con el título que le damos (FACTORIAL DE UN NÚMERO), consola espera a que el usuario introduzca un dato, imprime el resultado de la 
        /// operación que realiza la función que llamamos (GetFactorial) con el dato introducido y espera a que el Usuario pulse una tecla para volver al Menú principal.
        /// </summary>
        public static void LaunchFactirialMenu()
        {
            UserInterfaceMenu.PrintHead("       FACTORIAL DE UN NÚMERO       ", ConsoleColor.Yellow);
            Console.WriteLine("Muestra el resultado de la multiplicación de todos los números enteros positivos que hay entre el valor dado y el 1.");
            Console.WriteLine("");
            int number = ReadInteger("Introduce un valor: ");
            int result = Utils.GetFactorial(number);
            Console.WriteLine("Resultado: " + result);
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
            Program.LunchMainMenu();
        }

        /// <summary>
        /// Imprime el Menú con el título que le damos (SUMATORIO), consola espera a que el usuario introduzca un dato, imprime el resultado de la 
        /// operación que realiza la función que llamamos (GetSumatorio) con el dato introducido y espera a que el Usuario pulse una tecla para volver al Menú principal.
        /// </summary>
        public static void LaunchSumatoriMenu()
        {
            UserInterfaceMenu.PrintHead("             SUMATORIO              ", ConsoleColor.Blue);
            Console.WriteLine("Muestra el resultado de la suma desde el número 1 hasta el propio valor introducido.");
            Console.WriteLine("");

            while (true)
            {
                int number1 = ReadInteger("Introduce un valor: ");

                if (0 < number1)
                {
                    int result = Utils.GetSumatori(number1);
                    Console.WriteLine("Resultado de " + result);
                    break;
                }
                else
                {
                    Console.WriteLine("Error. El valor tiene que ser mayor que 1");
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
            Program.LunchMainMenu();
        }

        /// <summary>
        /// Imprime el Menú con el título que le damos (POTENCIA EN BASE 2), consola espera a que el usuario introduzca un dato, imprime el resultado de la 
        /// operación que realiza la función que llamamos (GetPowe2) con el dato introducido y espera a que el Usuario pulse una tecla para volver al Menú principal.
        /// </summary>
        public static void LaunchPower2Menu()
        {
            UserInterfaceMenu.PrintHead("         POTENCIA EN BASE 2         ", ConsoleColor.Red);
            Console.WriteLine("Muestra el resultado de multiplicar la base 2 por si mismo varias veces (exponente).");
            Console.WriteLine("");
            int number1 = ReadInteger("Introduce el exponente: ");
            double result = Utils.GetPower2(number1, 2);
            Console.WriteLine("Resultado:" + result);
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
            Program.LunchMainMenu();
        }

        /// <summary>
        /// Consola espera a que el usuario introduzca un dato el cual es un string y lo convierte a int para que se puedan realizar
        /// las operaciones que correspondan y en el caso de no ser un dato valido, le imprime un mensaje avisando al usuario.
        /// </summary>
        /// <param name="message"> Es el dato introducido por el usuario</param>
        /// <returns> Devuelve el dato introducido por el usuario si es correcto y si es erroneo un mensaje
        /// avisando al usuario de que ese dato no es valido
        /// </returns>
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
                    Console.WriteLine ("Número incorrecto");
                }
            }
        }

        /// <summary>
        /// Consola espera a que el Usuario introduzca un valor en string y transforma a int para que un switch
        /// sepa que opción del submenú eligió el usuario.
        /// </summary>
        /// <returns>
        /// Devuelve el dato introducido por el usuario y lo transforma de string a int.
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
