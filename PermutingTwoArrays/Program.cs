using System;
using System.Collections.Generic;

namespace PermutingTwoArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(twoArrays(5, new List<int>() { 2, 1, 3 }, new List<int>() { 7, 8, 9 }));
		}

		private static string twoArrays(int k, List<int> A, List<int> B)
		{
			A.Sort();
			B.Sort();
			B.Reverse();

			for (int i = 0; i < A.Count; i++)
			{
				if (A[i] + B[i] < k)
					return "No";
			}

			return "Yes";
		}
	}
}
