using System;
using System.Collections.Generic;

namespace CountingSort
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(CountingSort(new List<int>() { 1, 1, 3, 2, 1}));
		}

		private static List<int> CountingSort(List<int> arr)
		{
			var result = new List<int>();

			for (int i = 0; i < 100; i++)
			{
				result.Add(0);
			}

			for (int i = 0; i < arr.Count; i++)
			{
				var value = arr[i];
				result[value]++;
			}



			return result;
		}
	}
}
