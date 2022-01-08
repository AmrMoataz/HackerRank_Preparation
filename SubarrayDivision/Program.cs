using System;
using System.Collections.Generic;
using System.Linq;

namespace SubarrayDivision
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(SlidingWindow(new List<int>() { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1}, 18, 7));
		}

		// My Solution
		private static int Subdivision(List<int> s, int d, int m)
		{
			var ways = 0;

			for (int i = 0; i < s.Count; i++)
			{
				var offset = i + m;
				if (offset > s.Count)
					continue;

				var subArray = s.GetRange(i, m);
				var sum = 0;
				foreach (var num in subArray)
				{
					sum += num;
				}

				if (sum == d)
				{
					ways++;
				}
			}

			return ways;
		}

		// Solution from discussion
		private static int SlidingWindow(List<int>s, int d, int m)
		{
			int start = 0;
			int count = 0;
			int sum = 0;

			for (int i = 0; i < s.Count; i++)
			{
				sum += s[i];
				var lookupWindow = i - start + 1;
				if (lookupWindow == m)
				{
					if (sum == d)
					{
						count++;
					}

					sum -= s[start];
					start++;
				}
			}
			return count;
		}
	}
}
