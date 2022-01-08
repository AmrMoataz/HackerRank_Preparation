using System;
using System.Collections.Generic;

namespace DiagonalDifference
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = new List<List<int>>();

			arr.Add(new List<int> { 11, 2, 4 });
			arr.Add(new List<int> { 4, 5, 6 });
			arr.Add(new List<int> { 10, 8, -12 });

			Console.WriteLine(diagonalDifference(arr));
		}

		public static int diagonalDifference(List<List<int>> arr)
		{
			var leftDiagonalSum = 0;
			var rightDiagonalSum = 0;

			for (int i = 0; i < arr.Count; i++)
			{
				leftDiagonalSum += arr[i][i];
				rightDiagonalSum += arr[i][(arr.Count - i) - 1];
			}

			var result = (int)MathF.Abs(rightDiagonalSum - leftDiagonalSum);

			return result;
		}
	}
}
