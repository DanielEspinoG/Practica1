using System;

namespace Práctica1
{
    class Program
    {
        public static void LaunchPowerMenu()
        {
            while (true)
            {
                UserInterface.PrintPower2();
                int number1 = UserInterfaceUtils.ReadInteger("Número de la potencia");
                int result = UserInterfaceUtils.Power2(number1);

                int option = UserInterfaceUtils.ReadOption();
            }
        }
        public static void LunchMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterfaceUtils.ReadOption();
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Clear();
                        UserInterface.PrintAddHeader();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

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
