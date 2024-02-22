using System;

namespace Workshop1{
    public class Program
    {
        public static void Main(string[] args)
        {
            int choice = 0;
            LED led = new LED();

            while (true) {
                DisplayMenu();
                choice = getChoice();
                setChoice(choice, led);
            }
        }

        private static void DisplayMenu() {
            Console.WriteLine("Please enter your choice: ");
            Console.WriteLine("1. Turn on light");
            Console.WriteLine("2. Turn off light");
            Console.WriteLine("3. Exit");
            Console.Write("My choice: ");
        }

        private static int getChoice() {
            int choice = Convert.ToInt16(Console.ReadLine());
            return choice;
        }

        private static void setChoice(int choice, LED led)
        {
            switch (choice)
            {
                case 1:
                    led.isTurnOn();
                    PrintStatus(led);
                    break;
                case 2:
                    led.isTurnOff();
                    PrintStatus(led);
                    break;
                case 3:
                    Console.WriteLine();
                    System.Environment.Exit(0);
                    break;
            }
        }

        private static void PrintStatus(LED led) {
            Console.WriteLine("\n** The LED is now " + (led.isLEDOn() ? "ON and its color is " + led.getColor() : "OFF") + "**\n");
        }
    }
}