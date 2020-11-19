using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class Operations
    {
        /*
        public static string GetFibonacci()
        {
            int i = 0;
            int a = 1;
            int aa = 0;
            string a1 = a.ToString();
            string aa1 = aa.ToString();
            int result = 1;

            while (i < 300)
            {
                result = a + aa;
                string resultA = result.ToString();
                int aux = aa;
                aa = a;
                a = aux + aa;
                i++;
            }
            return a1 + aa1;
        }
        */

        public static void GetFibonacci ()
        {
            int i = 0;
            int a = 1;
            int aa = 0;
            Console.Write(aa + ", ");
            Console.Write(a);

            while (i <= 300)
            {
                if (i < 300)
                {
                    Console.Write(", ");
                    Console.Write(a + aa);
                    int aux = aa;
                    aa = a;
                    a = aux + aa;
                    i++;
                }
                else
                {
                    Console.WriteLine(".");
                    break;
                }
            }
        }
        
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

        public static int GetSumatori (int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
                result += i;
            return result;
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
