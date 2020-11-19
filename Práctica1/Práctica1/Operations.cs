using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class Operations
    {

        /*
        public static void GetFibonacci (int n)
        {
            int i = 0;
            int a = 1;
            int aa = 0;
            Console.Write(aa + ", ");
            Console.Write(a + ", ");

            while (i < n)
            {
                Console.Write((a + aa) + ", ");
                int aux = aa;
                aa = a;
                a = aux + aa;
                i++;
            }
        }
        */
        public static bool IsPrime (int n)
        {
            for (int i = 2; i < n; i++)
            {
                if ((n % i) == 0)
                    return false;
            }
            return true;
        }

        public static int GetFactorial (int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
                result = result * i;
            return result;
        }

        public static double GetAdd (double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Es una función que calcula la potencia de un número, sea su potencia positiva o negativa.
        /// </summary>
        /// <param name="n">Es la potencia</param>
        /// <param name="a">Es el número del cual se calcula su potencia (n)</param>
        /// <returns>Devuelve el resultado del numero "a" elevado a "n/-n"</returns>
        public static double Power2 (double n, double a)
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
