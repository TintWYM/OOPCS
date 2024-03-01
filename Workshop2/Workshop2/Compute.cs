using System;
namespace Workshop2
{
	public class Compute
	{
		public static void AddRandom(MyList list)
		{
			Random rand = new Random();
			int count = Helper.GetNumber("Number of random numbers to add: ");

			for (int i = 0; i < count; i++) {
				list.Add(rand.Next(0, 100));
			}

		}

		public static double ComputeMean(MyList list) {
			try
			{
				return Helper.ComputeSum(list) / list.GetCount();
			}
			catch(DivideByZeroException) {
				return 0;
			}
		}

        public static double ComputeStdDev(MyList list)
        {
            try
            {
                double stddev = 0.0;
                double mean = ComputeMean(list);
                int sum = Helper.ComputeSum(list);

                for (int i = 0; i < list.GetCount(); i++)
                {
                    stddev += Math.Pow((list.Get(i) - mean), 2);
                }

                stddev = Math.Sqrt(stddev / list.GetCount() - 1);
                return stddev;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }

        public static void RemoveFront(MyList list)
        {
            int count = Helper.GetNumber("Number of elements to remove: ");

            if (list.GetCount() >= count)
            {
                for (int i = 0; i < count; i++)
                {
                    list.Remove(0);
                }
            }
            else
            {
                Console.WriteLine("Number of elements exceeds list size");
            }
        }

        public static void RemoveBack(MyList list)
        {
            int count = Helper.GetNumber("Number of elements to remove: ");
            if (list.GetCount() >= count)
            {
                for (int i = 0; i < count; i++)
                {
                    list.Remove(list.GetCount() - 1);
                }
            }
            else
            {
                Console.WriteLine("Number of elements exceeds list size");
            }
        }
    }
}

