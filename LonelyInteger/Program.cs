using System;
using System.Collections.Generic;
using System.Linq;

namespace LonelyInteger
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(lonelyInteger(new List<int> { 1, 2, 3, 4, 3, 2, 1}));
		}

		public static int lonelyInteger(List<int> a)
		{
			var numsFound = new List<int>();

			foreach (var num in a)
			{
				if (!numsFound.Contains(num))
				{
					numsFound.Add(num);
				}
				else if (numsFound.Contains(num))
				{
					numsFound.Remove(num);
				}
			}

			return numsFound.First();
		}
	}
}
