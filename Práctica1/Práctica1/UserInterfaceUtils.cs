using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class UserInterfaceUtils
    {
        /*
        public static void LaunchFibonacciMenu()
        {
            while (true)
            {
                UserInterface.PrintFibonacciHead();
                int number = ReadInteger("¿Hasta que valor quieres ver? ");
                int result = Operations.GetFibonacci(number);
                Console.WriteLine("0 1" + result);
                Console.WriteLine("");
                UserInterface.PrinFibonacciSubMenu();
            }
        }
        */

        public static void LaunchPrimeMenu ()
        {
            while (true)
            {
                UserInterface.PrintPrimeHead();
                int number = ReadInteger("Introduce un valor: ");
                bool result = Operations.IsPrime(number);
                Console.WriteLine("Resultado: " + result);
                Console.WriteLine("");
                UserInterface.PrinPrimeSubMenu();
            }
        }

        public static void LaunchFactirialMenu()
        {
            while (true)
            {
                UserInterface.PrintFactorialHead();
                int number = ReadInteger("Introduce un valor: ");
                int result = Operations.GetFactorial(number);
                Console.WriteLine("Resultado: " + result);
                Console.WriteLine("");
                UserInterface.PrinFactorialSubMenu();
            }
        }

        public static void LaunchAddMenu()
        {
            while (true)
            {
                UserInterface.PrintAddHead();
                double number1 = ReadInteger("Introduce un valor: ");
                double number2 = ReadInteger("Introduce otro valor: ");
                double result = Operations.GetAdd(number1, number2);
                Console.WriteLine("Resultado de " + number1 + " + " + number2 + " = " + result);
                Console.WriteLine("");
                UserInterface.PrintAddSubMenu();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void LaunchPower2Menu()
        {
            while (true)
            {
                UserInterface.PrintPower2Head();
                double number1 = ReadInteger("Introduce la potencia de 2:");
                double result = Operations.Power2(number1, 2);
                Console.WriteLine("Resultado:" + result);
                Console.WriteLine("");
                UserInterface.PrinSubMenu();
            }
        }

        /// <summary>
        /// Sirve para detectar si el dato intruducido por el usuario es admitido y en el caso de 
        /// ser invalido notificar al usuario de que dicho dato es erroneo, que introduzca uno valido.
        /// </summary>
        /// <param name="message"> Es el dato introducido por el usuario </param>
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
        /// Consola espera a que el Usuario introduzca un dato
        /// </summary>
        /// <returns>
        /// Devuelve el dato introducido por el usuario
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
