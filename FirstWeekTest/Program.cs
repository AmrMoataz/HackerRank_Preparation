using System;
using System.Collections.Generic;

namespace FirstWeekTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var list = new List<List<int>>();
			list.Add(new List<int>() { 112, 42, 83, 119 });
			list.Add(new List<int>() { 56, 125, 56, 49 });
			list.Add(new List<int>() { 15, 78, 101, 43 });
			list.Add(new List<int>() { 62, 98, 114, 108 });
			Console.WriteLine(FlippingMatrix(list));
		}

		public static int findMedian(List<int> arr)
		{
			var count = arr.Count - 1;
			arr.Sort();

			return arr[count / 2];
		}

		public static int FlippingMatrix(List<List<int>> matrix)
		{
			var sum = 0;
			var subMatrixCount = matrix.Count / 2;

			for (int i = 0; i < subMatrixCount; i++)
			{
				for (int j = 0; j < subMatrixCount; j++)
				{
					var horizontalEnd = (matrix[i].Count - 1) - j;
					var verticalEnd = (matrix[i].Count - 1) - i;
					var topLeft = matrix[i][j];
					var bottomLeft = matrix[verticalEnd][j];
					var topRight = matrix[i][horizontalEnd];
					var bottomRight = matrix[verticalEnd][horizontalEnd];
					var max = Math.Max(Math.Max(topLeft, bottomLeft), Math.Max(topRight, bottomRight));
					sum += max;
				}
			}

			return sum;
		}
	}
}
