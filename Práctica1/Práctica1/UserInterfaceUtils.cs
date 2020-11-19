using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class UserInterfaceUtils
    {
        public static void LaunchFibonacciMenu()
        {
            UserInterface.PrintFibonacciHead();
            Operations.GetFibonacci();
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
            Program.LunchMainMenu();
        }

        public static void LaunchPrimeMenu ()
        {
            UserInterface.PrintPrimeHead();
            int number = ReadInteger("Introduce un valor: ");
            bool result = Operations.IsPrime(number);
            if (result == true)
                Console.WriteLine("El " + number + " SI es Primo");
            else
                Console.WriteLine("El " + number + " NO es Primo");
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
            Program.LunchMainMenu();
        }

        public static void LaunchFactirialMenu()
        {
            UserInterface.PrintFactorialHead();
            int number = ReadInteger("Introduce un valor: ");
            int result = Operations.GetFactorial(number);
            Console.WriteLine("Resultado: " + result);
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
            Program.LunchMainMenu();
        }

        public static void LaunchSumatoriMenu()
        {
                UserInterface.PrintAddHead();
            int number1 = ReadInteger("Introduce un valor: ");
            int result = Operations.GetSumatori(number1);
            Console.WriteLine("Resultado de " + result);
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
            Program.LunchMainMenu();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void LaunchPower2Menu()
        {
            UserInterface.PrintPower2Head();
            double number1 = ReadInteger("Introduce la potencia de 2:");
            double result = Operations.Power2(number1, 2);
            Console.WriteLine("Resultado:" + result);
            Console.WriteLine("");
            Console.WriteLine("Pulsa intro para volver al Menú Principal");
            Console.ReadLine();
            Program.LunchMainMenu();
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
