using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class Utils
    {
        /// <summary>
        /// Imprime los primeros 90 digitos de la serie de fibonacci. No imprime más de 90 ya que al ser de 64 bits no caben más digitos.
        /// </summary>
        public static void GetFibonacci (long n)
        {
            long i = 0;
            long number = 1;
            long result = 0;
            Console.Write(result + ", ");
            Console.Write(number);

            while (i <= n)
            {
                if (i < n)
                {
                    Console.Write(", ");
                    Console.Write(number + result);
                    long aux = result;
                    result = number;
                    number = aux + result;
                    i++;
                }
                else
                {
                    Console.WriteLine("...");
                    break;
                }
            }
        }
        
        /// <summary>
        /// Calcula si el valor dado (n) es primo o no.
        /// </summary>
        /// <param name="n">Es el valor del cual queremos saber si es primo</param>
        /// <returns>Devuelve un False o un True.</returns>
        public static bool IsPrime (int n)
        {
            for (int i = 2; i < n; i++)
                if ((n % i) == 0)
                    return false;
            return true;
        }

        /// <summary>
        /// Calcula el factorial de un número, el cual, calcula el producto de todos los números enteros positivos desde 1 hasta "n".
        /// </summary>
        /// <param name="n">Es el valor hasta el cual multiplica</param>
        /// <returns>Devuelve el resultado total de todas las multiplicaciones realizadas</returns>
        public static int GetFactorial (int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
                result = result * i;
            return result;
        }

        /// <summary>
        /// Calcula el Sumatorio de un número, el cual, al darle el valor "n" suma desde el valor 1 hasta "n".
        /// </summary>
        /// <param name="n">Es el valor hasta el cual va a sumar</param>
        /// <returns>Devuelve el resultado total de las sumas realizadas</returns>
        public static int GetSumatori (int n)
        {
            int result = 0;
            if (0 < n)
            {
                for (int i = 1; i <= n; i++)
                    result += i;
                return result;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Calcula la potencia de un número, el cual, al darle los valores "n" (base) y "a" (exponente) multiplica el valor n tantas veces como sea "a",
        /// sea su potencia positiva o negativa.
        /// </summary>
        /// <param name="n">Es la base</param>
        /// <param name="a">Es el exponente, tantas veces como se repite el bucle</param>
        /// <returns>Devuelve el resultado del número "a" elevado a "n" o "-n"</returns>
        public static double GetPower2 (double n, double a)
        {
            if (0 <= n)
            {
                double result = 1;
                for (double i = 0; i < n; i++)
                    result *= a;
                return result;
            }
            else
            {
                double result = 1;
                for (double i = 0; i < -n; i++)
                    result *= a;
                    result = 1 / result;
                return result;
            }
        }
    }
}
