using System;

namespace DrawingBook
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(PageCount(6, 5));
		}

		private static int PageCount(int n, int p)
		{
			var left = p / 2;
			var right = (n /2) - (p / 2);

			return left < right ? left : right;
		}
	}
}
