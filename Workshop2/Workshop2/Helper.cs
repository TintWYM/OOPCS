using System;
namespace Workshop2
{
	public class Helper
	{
		public static void PrintList(MyList list)
		{
			Console.Write("** List = [");
			for (int i = 0; i < list.GetCount(); i++) {
				Console.WriteLine(" " + list.Get(i));
			}

			Console.WriteLine(" ] **\n");
		}

		public static int ComputeSum(MyList list) {
			int sum = 0;
			for (int i = 0; i < list.GetCount(); i++) {
				sum += list.Get(i);
			}

			return sum;
		}

		public static int GetNumber(String text) {
			Console.WriteLine(text);
			return Convert.ToInt32(Console.ReadLine());
		}
	}
}

