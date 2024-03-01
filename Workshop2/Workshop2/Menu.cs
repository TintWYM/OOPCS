using System;
namespace Workshop2
{
	public class Menu
	{
		public static void DisplayMenu()
		{
			Console.WriteLine("Please enter your choice: ");
            Console.WriteLine("1. Add random number to list");
            Console.WriteLine("2. Compute mean");
            Console.WriteLine("3. Compute std dev");
            Console.WriteLine("4. Remove elements from front");
            Console.WriteLine("5. Remove elements from back");
            Console.WriteLine("6. Exit");
            Console.Write("My Choice: ");
        }

        public static int GetChoice() {
            int choice = Convert.ToInt32(Console.ReadLine());
        }

        public static void ProcessChoice(int choice, MyList list) {
            switch (choice)
            {
                case 1:
                    Compute.AddRandom(list);
                    Helper.PrintList(list);
                    break;
                case 2:
                    Console.WriteLine("Mean: " + Compute.ComputeMean(list));
                    break;
                case 3:
                    Console.WriteLine("Mean: " + Compute.ComputeStdDev(list));
                    break;
                case 4:
                    Compute.RemoveFront(list);
                    Helper.PrintList(list);
                    break;
                case 5:
                    Compute.RemoveBack(list);
                    Helper.PrintList(list);
                    break;
                case 6:
                    Console.WriteLine("\nExiting...");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
	}
}

