using System;
using System.Collections.Generic;

namespace MinMaxSUm
{
	class Program
	{
		static void Main(string[] args)
		{
            var intList = new List<int> { 1, 3, 5, 7, 9 };
            minMaxSum(intList);
		}

		private static void minMaxSum(List<int> arr)
		{
            var minSum = long.MaxValue;
            var maxSum = long.MinValue;

            for (int i = 0; i < arr.Count; i++)
            {
                var sum = (long)0;
                for (var j = 0; j < arr.Count; j++)
                {
                    var num = (long)arr[j];
                    if (j != i)
                    {
                        sum += num;
                    }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }   
                if (sum < minSum)
                {
                    minSum = sum;
                }
            }

			Console.WriteLine($"{minSum} {maxSum}");
        }
	}
}
