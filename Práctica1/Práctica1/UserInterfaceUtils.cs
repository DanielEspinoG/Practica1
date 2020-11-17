using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class UserInterfaceUtils
    {
        public static int Power2(int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
                result *= 2;
            return result;
        }
        /// <summary>
        /// Consola espera a que el Usuario introduzca el número de la opción que desea del Menú
        /// </summary>
        /// <returns>
        /// Muestra el Menú de la opción elegida o se sale de consola
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
