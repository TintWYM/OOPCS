using System;
namespace Workshop2
{
	public class MyList
	{
		private readonly List<int> list;

		public MyList()
		{
			this.list = new List<int>();
		}

		public int GetCount() {
			return list.Count;
		}

		public int Get(int index) {
			return list[index];
		}

		public void Add(int num)
		{
			list.Add(num);
		}

		public void Remove(int index) {
			list.Remove(index);
		}
	}
}

